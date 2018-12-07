using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDecontominators
{
    public partial class OneDec : Form
    {
        bool Start = false;
        /// <summary>
        /// Установка в группе работает последовательно по следующим циклам:
        /// 1. Нагрев формалина.
        /// 2. Испарение формалина.
        /// 3. Выдержка.
        /// 4. Нагрев аммиака.
        /// 5. Испарение аммиака.
        /// 
        /// </summary>
        int Stage; // циклы
        int Popitki;//
        bool Formalin;
        bool Ammiac;
        Form1 form1;
        DateTime ftime;
        DateTime atime;
        DateTime wtime;
        public OneDec()
        {
            form1 = new Form1();
            InitializeComponent();
            toolStripStatusLabel1.Text = "...";
            Stage = 1;
            Popitki = 0;
            Formalin = false;
            Ammiac = false;


            ftime = new DateTime(2018, 10, 18, 0, 0, 0);
            atime = new DateTime(2018, 10, 18, 0, 0, 0);
            wtime = new DateTime(2018, 10, 18, 0, 0, 0);

            dateTimePickerFormalin.Value = wtime.Add(form1.Set.TimeFormalin);
            dateTimePickerAmmiac.Value = wtime.Add(form1.Set.TimeAmmiac);
            dateTimePickerWait.Value = wtime.Add(form1.Set.TimeWaiting);

            try
            {
                // Decontaminator decontaminator = new Decontaminator(1, 1); 
                //    decontaminator = new Decontaminator(1, 1);
                form1.Send2ModbusFun3();
                timer2.Interval = 500;
                timer2.Start();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.ToString();
            }
        }

        public bool stateOne { get => Start; set => Start = value; }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
        }
        int z1 = 1;
        private string RotateImg()
        {
            z1++;
            if (z1 > 3) z1 = 0;
            string[] s1 = { "/", "-","\\","|"};
            return s1[z1];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //// работаем по циклам
            switch (Stage)
            {
                case 1: // 1. Нагрев формалина.
                    if ((form1.Regs.TE1 > form1.Regs.UTElo ))
                    {
                        Stage = 2;
                        Formalin = true;
                        Ammiac = true;
                        progressBarFormalin.Maximum = dateTimePickerFormalin.Value.Hour * 60 * 60 
                            + dateTimePickerFormalin.Value.Minute * 60 
                            + dateTimePickerFormalin.Value.Second;
                        progressBarFormalin.Value = 0;
                        progressBarFormalin.Step = 1;

                    }
                    toolStripStatusLabel1.Text = "Ждем нагрева формалина..."+ RotateImg();
                    break;
                case 2: // 2. Испарение формалина.
                    if (Formalin)
                    {
                        dateTimePickerFormalin.Value = dateTimePickerFormalin.Value.Subtract(new TimeSpan(0, 0, 1));
                        progressBarFormalin.PerformStep();
                        if ((dateTimePickerFormalin.Value.Hour == 0
                            && dateTimePickerFormalin.Value.Minute == 0
                            && dateTimePickerFormalin.Value.Second == 0
                            ))
                        {
                            // Stage = 3;
                            Formalin = false;
                            progressBarWating.Maximum = dateTimePickerWait.Value.Hour * 60 * 60
                                + dateTimePickerWait.Value.Minute * 60
                                + dateTimePickerWait.Value.Second;
                            progressBarWating.Value = 0;
                            progressBarWating.Step = 1;
                            //                        dateTimePickerFormalin.Value = wtime.Add(form1.Set.TimeFormalin);
                            //                       if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();

                            //    form1.timer.Stop();
                            //    form1.Send2ModbusFun10(17, 0); // OTКЛ
                            //    System.Threading.Thread.Sleep(100);//ОБОЖДЕМ 100 МИЛИСЕК
                            //    form1.timer.Start();
                        }
                    }
                        toolStripStatusLabel1.Text = "Испарение формалина..." + RotateImg();
                    
                    break;
                case 3: // 3. Выдержка.
                    dateTimePickerWait.Value = dateTimePickerWait.Value.Subtract(new TimeSpan(0, 0, 1));
                    progressBarWating.PerformStep();
                    if (dateTimePickerWait.Value.Hour == 0
                        && dateTimePickerWait.Value.Minute == 0
                        && dateTimePickerWait.Value.Second == 0
                        )
                    {
//                        if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();
                        form1.timer.Stop();
                        Stage = 4;
////                        Stage = 5; 
                        form1.Send2ModbusFun10(18, 0);//ammiac
                        System.Threading.Thread.Sleep(1000);//ОБОЖДЕМ 1 СЕК//
                        form1.Send2ModbusFun10(17, 1); // 
                        form1.timer.Start();
                    }

                    toolStripStatusLabel1.Text = "Выдержка..." + RotateImg();
                    break;
                case 4: // 4. Нагрев аммиака.
                    ////if ((form1.Regs.State & 8) != 0)// проскакиваем этот этап на время
                    if(true)
                    {
                        Stage = 5;
                        progressBarAmmiac.Maximum = dateTimePickerAmmiac.Value.Hour * 60 * 60
                            + dateTimePickerAmmiac.Value.Minute * 60
                            + dateTimePickerAmmiac.Value.Second;
                        progressBarAmmiac.Value = 0;
                        progressBarAmmiac.Step = 1;

                    }
                    toolStripStatusLabel1.Text = "Нагрев аммиака..." + RotateImg();
                    break;
                case 5: // 5. Испарение аммиака.
                    if (Ammiac)
                    {
                        toolStripStatusLabel1.Text = "Испарение аммиака..." + RotateImg();
                        progressBarAmmiac.PerformStep();
                        dateTimePickerAmmiac.Value = dateTimePickerAmmiac.Value.Subtract(new TimeSpan(0, 0, 1));
                        if ((dateTimePickerAmmiac.Value.Hour == 0
                            && dateTimePickerAmmiac.Value.Minute == 0
                            && dateTimePickerAmmiac.Value.Second == 0
                            ) && ((form1.Regs.TE1 > form1.Regs.UTEhi) || (form1.Regs.TE2 > form1.Regs.UTEhi)))
                        {
                            //                        if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();
                            //                        form1.timer.Stop();
                            //    Stage = 0;
                            toolStripStatusLabel1.Text = "Испарение аммиака завершено по таймеру.";
                            Ammiac = false;
                            //                        form1.Send2ModbusFun10(17, 0);
                            //                        System.Threading.Thread.Sleep(100);//ОБОЖДЕМ 100 МИЛИСЕК
                            //                        form1.timer.Start();
                        }
                    }
                    toolStripStatusLabel1.Text = "Испарение аммиака..." + RotateImg();
                    break;
            }

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings(form1);
            frm.ShowDialog(form1);


            //ftime = new DateTime(2018, 10, 18, 0, 0, 0);
            atime = new DateTime(2018, 10, 18, 0, 0, 0);
            //wtime = new DateTime(2018, 10, 18, 0, 0, 0);
           
            dateTimePickerFormalin.Value = atime.Add(form1.Set.TimeFormalin);
            dateTimePickerAmmiac.Value = atime.Add(form1.Set.TimeAmmiac);
            dateTimePickerWait.Value = atime.Add(form1.Set.TimeWaiting);

        }

        private void start_Click(object sender, EventArgs e)
        {

            Start = !Start;
            if (Start)
            {
                //if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();
                Stage = 1;
                form1.timer.Stop();
                button1.Text = "СТОП";
                //form1.Send2ModbusFun3();
                form1.Send2ModbusFun10(17, 1); // ВКЛ
                timer1.Start();
                toolStripStatusLabel1.Text = "запуск алгоритма";
                form1.Send2ModbusFun10(18, 1);//формалин.
                button2.Enabled = false;
                System.Threading.Thread.Sleep(100);//ОБОЖДЕМ 100 МИЛИСЕК
                form1.timer.Start();

            }
            else
            {
                Stage = 1;
                //if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();
                form1.timer.Stop();
                button1.Text = "ПУСК";
                timer1.Stop();
                //form1.btnDisconnect_Click(sender, e);
                //form1.timer.Stop();
                toolStripStatusLabel1.Text = "останов алгоритма";
                form1.Send2ModbusFun10(17, 0); // OTКЛ
                button2.Enabled = true;
                System.Threading.Thread.Sleep(100);//ОБОЖДЕМ 100 МИЛИСЕК
                form1.timer.Start();
                progressBarAmmiac.Value = 0;
                progressBarFormalin.Value = 0;
                progressBarWating.Value = 0;

                dateTimePickerFormalin.Value = wtime.Add(form1.Set.TimeFormalin);
                dateTimePickerAmmiac.Value = wtime.Add(form1.Set.TimeAmmiac);
                dateTimePickerWait.Value = wtime.Add(form1.Set.TimeWaiting);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();
            form1.timer.Stop();
            form1.Send2ModbusFun10(24, 1);
            Stage = 1;
            //        form1.Send2ModbusFun3();
            //        form1.btnDisconnect_Click(sender,e);
            System.Threading.Thread.Sleep(100);//ОБОЖДЕМ 100 МИЛИСЕК
            form1.timer.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(((form1.Regs.TE1 > form1.Regs.UTEhi) || (form1.Regs.TE2 > form1.Regs.UTEhi)) && (form1.Regs.SK1 > 0) )
            {
                //Start = true;
                //if (Start)
                //{
                    //start_Click(sender, e);
                    toolStripStatusLabel1.Text = "отключаем нагрев по догреву до осушения бака...";
                //}
                if (Stage == 2)
                {
                    Stage = 3;
                    progressBarWating.Maximum = dateTimePickerWait.Value.Hour * 60 * 60
                        + dateTimePickerWait.Value.Minute * 60
                        + dateTimePickerWait.Value.Second;
                    progressBarWating.Value = 0;
                    progressBarWating.Step = 1;

                }
                if (Stage == 5)
                {
                    Stage = 0;
                    //Start = true;
                    //if (Start)
                    //{
                    //    start_Click(sender, e);
                    //}
                    timer1.Stop();
                }
                form1.timer.Stop();
                if(Popitki%7 != 0) form1.Send2ModbusFun10(17, 0); // ОТКЛ
                if (Popitki == 30) form1.Send2ModbusFun10(17, 0); // ОТКЛ
                if (Popitki == 70) form1.Send2ModbusFun10(17, 0); // ОТКЛ
                if (Popitki == 220) form1.Send2ModbusFun10(17, 0); // ОТКЛ
                if (Popitki == 380) form1.Send2ModbusFun10(17, 0); // ОТКЛ
                System.Threading.Thread.Sleep(300);
                if (Popitki%33 != 0) form1.Send2ModbusFun3();
                Popitki++;
                //System.Threading.Thread.Sleep(1000);
                //form1.timer.Start();

            }
            if ((form1.Regs.HLA == 1))
            {
                labelAvaria.Visible = true;
                /// start_Click(sender, e);
                /// 
                Stage = 1;
                progressBarAmmiac.Value = 0;
                progressBarFormalin.Value = 0;
                progressBarWating.Value = 0;
                dateTimePickerFormalin.Value = wtime.Add(form1.Set.TimeFormalin);
                dateTimePickerAmmiac.Value = wtime.Add(form1.Set.TimeAmmiac);
                dateTimePickerWait.Value = wtime.Add(form1.Set.TimeWaiting);


                if (Start)
                {
                    Start = false;
                    button1.Text = "ПУСК";
                    timer1.Stop();
                    toolStripStatusLabel1.Text = "система останавливается по аварии...";
                    button2.Enabled = true;
                    Stage = 0;
                    form1.Send2ModbusFun10(17, 0); // ОТКЛ
                    System.Threading.Thread.Sleep(1000);
                    form1.timer.Start();
                }
                //form1.btnDisconnect_Click(sender, e);
                //form1.timer.Stop();
                //if (form1.Regs.SK1 == 1)
                //{
                //    //if (form1.cancellationTokenSource != null) form1.cancellationTokenSource.Cancel();
                //    form1.timer.Stop();
                //    // buttonReset.Visible = true;
                //    System.Threading.Thread.Sleep(1000);//ОБОЖДЕМ 1 СЕК
                //    form1.Send2ModbusFun3();
                //    System.Threading.Thread.Sleep(1000);
                //    form1.timer.Start();
                //}
            }
            else
            {
                labelAvaria.Visible = false;
                // buttonReset.Visible = false;
            }



            //if (((short)form1.Regs.TE1 > (short)form1.Regs.UTEhi))
            //{
            //   // toolStripStatusLabel1.Text = "Превышена температура нагрева формалина. Допустимая температура " + ((short)form1.Regs.UTEhi).ToString() + ". Температура бака " + ((short)form1.Regs.TE1).ToString()+". ";
            //}
 
            //if (form1.Regs.TE2 > form1.Regs.UTEhi)
            //{
            //  //  toolStripStatusLabel1.Text += "Превышена температура 2 нагрева формалина. Допустимая температура " + ((short)form1.Regs.UTEhi).ToString() + ". Температура бака " + ((short)form1.Regs.TE2).ToString();
            //}
 

            if (form1.Regs.HLW == 1)
            {
               // lHLW.Text = "Работа Вкл";
                lHLW.Enabled = true;
            }
            else
            {
               // lHLW.Text = "РАБОТ";
                lHLW.Enabled = false;
            }



            labelUTEhi.Text = form1.Regs.UTEhi.ToString();

            lTE1.Text = form1.lTE1.Text;
            lTE2.Text = form1.lTE2.Text;

            if (form1.Regs.HLW == 1)
            {
             //   lHLW.Text = "Работа Вкл";
                lHLW.Enabled = true;
            }
            else
            {
            //    lHLW.Text = "Работа Откл";
                lHLW.Enabled = false;
            }

        }
    }
}
