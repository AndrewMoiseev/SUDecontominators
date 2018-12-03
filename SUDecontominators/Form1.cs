using Mesages;
using System;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDecontominators
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;
        public Settin Set = new Settin(1, 1, "base.sqlite");

        private RegistersFromDecontaminator regs;

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer = timer1;
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            this.Width = 470;
            Regs = new RegistersFromDecontaminator();


        }

        NetworkStream stream;
        CancellationTokenSource cancellationTokenSource;


        internal RegistersFromDecontaminator Regs { get => regs; set => regs = value; }

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

        //       private static bool IsConnect = false;



        public async void Send2ModbusFun3()
        {
            timer.Interval = Set.PollingInterval * 1000;
            if (!timer.Enabled) timer.Start();

            try
            {
                btnConnect.Enabled = false;

                var client = new TcpClient();

                try
                {
                    //if(!client.Connected)
                    await client.ConnectAsync(Set.IPAddress, Set.Port);

                    byte[] sendBytes;

                    btnDisconnect.Enabled = true;
//                    IsConnect = true;

                    cancellationTokenSource = new CancellationTokenSource();
                    stream = client.GetStream();
                    //[01][03][00][00][00][20][44][12]
                    sendBytes = new byte[8] { 1, 3, 0, 0x00, 0, 0x20, 0x44, 0x12 };
                    //       sendBytes = new byte[12] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x00, 0x00, 0x20 };

                    await stream.SendRawMessage(sendBytes);
                    ///////////////////////    DEBUG
                    if (Width > 500)
                    {
                        string Text = "";
                        for (int i = 0; i < sendBytes.Length; i++)
                        {
                            Text += String.Format("{0:x2} ", sendBytes[i]);
                        }
                        listBox1.Items.Add(Text);
                        listBox1.Items.Add("");
                    }
                    /////////////////////////

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

                            lCount.Text = Regs.Count.ToString();
                            lSec.Text = Regs.Sec.ToString();
                            lTE1.Text = Regs.TE1.ToString();
                            lTE2.Text = Regs.TE2.ToString();

                            lUTEhi.Text = Regs.UTEhi.ToString();
                            lUTElo.Text = Regs.UTElo.ToString();
                            lUtmin.Text = Regs.Utmin.ToString();


                            if (Regs.ST1 == 1)
                            {
                                lST1.Text = "ST1 Вкл";
                                lST1.Enabled = true;
                            }
                            else
                            {
                                lST1.Text = "ST1 Выкл";
                                lST1.Enabled = false;
                            }


                            if (Regs.ST2 == 1)
                            {
                                lST2.Text = "ST2 Вкл";
                                lST2.Enabled = true;
                            }
                            else
                            {
                                lST2.Text = "ST2 Выкл";
                                lST2.Enabled = false;
                            }
                            if (Regs.HLA == 1)
                                label2.Visible = true;
                            else
                                label2.Visible = false;

                            if (Regs.HLW == 1)
                            {
                                lHLW.Text = "Работа Вкл";
                                lHLW.Enabled = true;
                            }
                            else
                            {
                                lHLW.Text = "Работа Выкл";
                                lHLW.Enabled = false;
                            }

                            if (Regs.SK2 == 0)
                            {
                                lRelay2.Text = "Аммиак";
                            }
                            else if (Regs.SK2 == 1)
                            {
                                lRelay2.Text = "Формалин";
                            }
                            else
                            {
                                lRelay2.Text = "неопределенно";
                            }


                            if (Regs.SK1 == 0)
                            {
                                lRelay1.Text = "Откл";
                            }
                            else if (Regs.SK1 == 1)
                            {
                                lRelay1.Text = "Вкл";
                            }
                            else
                            {
                                lRelay1.Text = "неопределенно";
                            }


                            if ((Regs.State & 1) == 0)
                            {
                                label3.Enabled = false;
                            }
                            else
                            {
                                label3.Enabled = true;
                            }

                            if ((Regs.State & 2) == 0)
                            {
                                label4.Enabled = false;
                            }
                            else
                            {
                                label4.Enabled = true;
                            }
                            if ((Regs.State & 4) == 0)
                            {
                                label5.Enabled = false;
                            }
                            else
                            {
                                label5.Enabled = true;
                            }
                            if ((Regs.State & 8) == 0)
                            {
                                label6.Enabled = false;
                            }
                            else
                            {
                                label6.Enabled = true;
                            }


                            if (Width > 500)
                            {
                                string Text = "";
                                for (int i = 0; i < 64; i++)
                                {
                                    if ((i % 2) == 0) Text += String.Format("{0:00}", (i / 2)) + ":[";
                                    Text += String.Format("{0:x2}", message[i]);
                                    if ((i % 2) != 0) Text += "] ";
                                    if ((i == 15) || (i == 31) || (i == 47))
                                    {
                                        listBox1.Items.Add(Text);
                                        Text = "";
                                    }
                                }
                                listBox1.Items.Add(Text);
                                listBox1.Items.Add("");
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
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
//                IsConnect = false;
                
            }

        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            Send2ModbusFun3();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Send2ModbusFun3();
        }

        //private async void btnSend_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        btnSend.Enabled = false;

        //        // Only send if we have a connection open
        //        if (btnDisconnect.Enabled)
        //        {
        //            var messageBytes = Encoding.UTF8.GetByteCount("");

        //            var data = new byte[messageBytes + 1];
        //            data[0] = (byte)MessageId.ChatMessage;
        //            Encoding.UTF8.GetBytes("", 0, "".Length, data, 1);

        //            await stream.SendRawMessage(data);
        //        }
        //    }
        //    finally
        //    {
        //        btnSend.Enabled = true;
        //    }
        //}

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
            // Signal the connection handler to close the connection
            if (cancellationTokenSource != null) cancellationTokenSource.Cancel();
            timer.Stop();
        }

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Width < 500)
                Width = 1180;
            else
                Width = 470;
        }

        public void bClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            ushort temp = Convert.ToUInt16( numericUpDownTempBak.Value);
            Send2ModbusFun10(25, temp);
        }

        public void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void toolStripMenuSettings_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings(this);
            frm.ShowDialog(this);
        }

        public void Form1_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        public void Form1_Resize(object sender, EventArgs e)
        {
            listBox1.Size = new System.Drawing.Size((this.Size.Width - 512), (this.Size.Height - 80));
        }

        public void bK1on_Click(object sender, EventArgs e)
        {
            Send2ModbusFun10(17,1);
        }

        public async void Send2ModbusFun10(byte addr,ushort regval)
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
                    ///////////////////////                 DEBUG
                    if (Width > 500)
                    {
                        string Text = "";
                        for (int i = 0; i < data.Length; i++)
                        {
                            Text += String.Format("{0:x2} ", data[i]);
                        }
                        listBox1.Items.Add(Text);
                        listBox1.Items.Add("");
                    }                   
                    /////////////////////////



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


                            if (Width > 500)
                            {
                                string Text = "";
                                for (int i = 0; i < message.Length; i++)
                                {
                                    if ((i % 2) == 0) Text += String.Format("{0:00}", (i / 2)) + ":[";
                                    Text += String.Format("{0:x2}", message[i]);
                                    if ((i % 2) != 0) Text += "] ";
                                    if ((i == 15) || (i == 31) || (i == 47))
                                    {
                                        listBox1.Items.Add(Text);
                                        Text = "";
                                    }
                                }
                                listBox1.Items.Add(Text);
                                listBox1.Items.Add("");
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

        public void bK1off_Click(object sender, EventArgs e)
        {
            Send2ModbusFun10(17, 0);
        }

        public void Ammiac_Click(object sender, EventArgs e)
        {
            Send2ModbusFun10(18, 0);
        }

        public void Formalin_Click(object sender, EventArgs e)
        {
            Send2ModbusFun10(18, 1);
        }

        public void Reset_Click(object sender, EventArgs e)
        {
            Send2ModbusFun10(24, 1);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            ushort temp = Convert.ToUInt16(numericUpDownUTElo.Value);
            Send2ModbusFun10(26, temp);
        }

        public void button7_Click(object sender, EventArgs e)
        {
            ushort temp = Convert.ToUInt16(numericUpDownUtmin.Value);
            Send2ModbusFun10(27, temp);
        }
    }
}
