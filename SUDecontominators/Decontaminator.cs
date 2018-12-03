using Mesages;
using System;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SUDecontominators
{

    class Decontaminator
    {
        //private static Timer timer;
        private RegistersFromDecontaminator regs;
        public RegistersFromDecontaminator Regs { get => regs; set => regs = value; }
        public NetworkStream stream;
        public CancellationTokenSource cancellationTokenSource;
        public System.Timers.Timer timer;

        public Decontaminator(int sysnum, int item)
        {
            Set = new Settin(sysnum, item, "base.sqlite");
            timer = new System.Timers.Timer(20000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Send2ModbusFun3();
        }
        public Settin Set;

        public void SetState()
        {
            Send2ModbusFun10(24, 1);
        }

        public void ResetState()
        {
            Send2ModbusFun10(24, 1);
        }

        public void K1_on()
        {
            Send2ModbusFun10(17, 1);
        }

        public void K1_off()
        {
            Send2ModbusFun10(17, 0);
        }

        public void Ammiac()
        {
            Send2ModbusFun10(18, 0);
        }

        public void Formalin()
        {
            Send2ModbusFun10(18, 1);
        }


        private async void Send2ModbusFun3()
        {
            timer.Interval = Set.PollingInterval * 1000;
            if (!timer.Enabled) timer.Start();

            try
            {
                var client = new TcpClient();
                try
                {
                    //if(!client.Connected)
                    await client.ConnectAsync(Set.IPAddress, Set.Port);

                    byte[] sendBytes;

                    //                    IsConnect = true;

                    cancellationTokenSource = new CancellationTokenSource();
                    stream = client.GetStream();
                    //[01][03][00][00][00][20][44][12]
                    sendBytes = new byte[8] { 1, 3, 0, 0x00, 0, 0x20, 0x44, 0x12 };
                    //       sendBytes = new byte[12] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x00, 0x00, 0x20 };

                    await stream.SendRawMessage(sendBytes);

                    var cancellationToken = cancellationTokenSource.Token;
                    var cancellationTask = cancellationToken.AsTask();

                    while (!cancellationToken.IsCancellationRequested)
                    {
                        var messageTask = stream.ReadRawMessage();

                        await Task.WhenAny(messageTask, cancellationTask);

                        if (messageTask.IsCompleted)
                        {
                            byte[] message = messageTask.GetAwaiter().GetResult();

                            //Принудительно закроем, может перестанет вылетать...

                            try
                            {
                                if (cancellationTokenSource != null) cancellationTokenSource.Cancel();
                            }
                            catch
                            {
                                // Do nothing
                            }
                            if (message == null)
                            {
                                return;
                            }

                            // тут делаем свои дела по чтению регистров c обменом старший-младший байт
                            Regs.State = BitConverter.ToUInt16(message.Skip(0).Take(2).Reverse().ToArray(), 0);

                            Regs.TE1ADC = BitConverter.ToUInt16(message.Skip(2).Take(2).Reverse().ToArray(), 0);
                            Regs.TE2ADC = BitConverter.ToUInt16(message.Skip(4).Take(2).Reverse().ToArray(), 0);
                            Regs.Sec = BitConverter.ToUInt16(message.Skip(6).Take(2).Reverse().ToArray(), 0);
                            Regs.TE1 = BitConverter.ToUInt16(message.Skip(8).Take(2).Reverse().ToArray(), 0);
                            Regs.TE2 = BitConverter.ToUInt16(message.Skip(10).Take(2).Reverse().ToArray(), 0);
                            Regs.Count = BitConverter.ToUInt16(message.Skip(12).Take(2).Reverse().ToArray(), 0);
                            Regs.AdrMB = BitConverter.ToUInt16(message.Skip(14).Take(2).Reverse().ToArray(), 0);
                            Regs.HLA = BitConverter.ToUInt16(message.Skip(16).Take(2).Reverse().ToArray(), 0);
                            Regs.SK1 = BitConverter.ToUInt16(message.Skip(18).Take(2).Reverse().ToArray(), 0);
                            Regs.SK2 = BitConverter.ToUInt16(message.Skip(20).Take(2).Reverse().ToArray(), 0);
                            Regs.ST1 = BitConverter.ToUInt16(message.Skip(22).Take(2).Reverse().ToArray(), 0);
                            Regs.ST2 = BitConverter.ToUInt16(message.Skip(24).Take(2).Reverse().ToArray(), 0);
                            Regs.HLW = BitConverter.ToUInt16(message.Skip(30).Take(2).Reverse().ToArray(), 0);
                            Regs.K1 = BitConverter.ToUInt16(message.Skip(34).Take(2).Reverse().ToArray(), 0);
                            Regs.K2 = BitConverter.ToUInt16(message.Skip(36).Take(2).Reverse().ToArray(), 0);
                            Regs.RState = BitConverter.ToUInt16(message.Skip(48).Take(2).Reverse().ToArray(), 0);
                            Regs.UTEhi = BitConverter.ToUInt16(message.Skip(50).Take(2).Reverse().ToArray(), 0);
                            Regs.UTElo = BitConverter.ToUInt16(message.Skip(52).Take(2).Reverse().ToArray(), 0);
                            Regs.Utmin = BitConverter.ToUInt16(message.Skip(54).Take(2).Reverse().ToArray(), 0);

                        }

                        if (cancellationTask.IsCompleted)
                        {
                            return;
                        }
                    }
                }
                finally
                {

                    client.Close();
                }
            }
            finally
            {
                //                IsConnect = false;

            }

        }
               
        private async void Send2ModbusFun10(byte addr, ushort regval)
        {

            ushort crc = 0;

            try
            {
                //btnConnect.Enabled = false;

                var client = new TcpClient();

                try
                {
                    //if(!client.Connected)
                    await client.ConnectAsync(Set.IPAddress, Set.Port);

                    cancellationTokenSource = new CancellationTokenSource();
                    stream = client.GetStream();

                    byte HighByte = (byte)(regval >> 8);
                    byte LowByte = (byte)(regval & 0xFF);

                    var data = new byte[11] { 1, 0x10, 0x00, addr, 0x00, 0x01, 0x02, HighByte, LowByte, 0xa4, 0xb4 };
                    crc = CRC16(data, 9);
                    data[9] = (byte)(crc & 0x00FF);
                    data[10] = (byte)((crc & 0xFF00) >> 8);
                    await stream.SendRawMessage(data);



                    var cancellationToken = cancellationTokenSource.Token;
                    var cancellationTask = cancellationToken.AsTask();

                    while (!cancellationToken.IsCancellationRequested)
                    {
                        var messageTask = stream.ReadRawMessage();

                        await Task.WhenAny(messageTask, cancellationTask);

                        if (messageTask.IsCompleted)
                        {
                            byte[] message = messageTask.GetAwaiter().GetResult();

                            //Принудительно закроем, может перестанет вылетать...

                            try
                            {
                                if (cancellationTokenSource != null) cancellationTokenSource.Cancel();
                            }
                            catch
                            {
                                // Do nothing
                            }
                            if (message == null)
                            {
                                return;
                            }

                        }

                        if (cancellationTask.IsCompleted)
                        {
                            return;
                        }
                    }
                }
                finally
                {

                    client.Close();
                }
            }
            finally
            {
                //
            }

        }





        public ushort CRC16(byte[] buf, int len)
        {
           
            int crc;
            byte i, I = 0;
            crc = 0xFFFF;
            while (len-- > 0)
            {
                crc ^= buf[I++];
                for (i = 0; i < 8; i++) crc = (crc & 0x0001) > 0 ? (crc >> 1) ^ 0xA001 : crc >> 1;
            }
            return (ushort)crc;
        }

    }
}
