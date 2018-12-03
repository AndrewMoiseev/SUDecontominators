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



            if (form1.Regs.HLA == 1)
            {
                labelAvaria.Visible = true;
                start_Click(sender, e);
                buttonReset.Visible = true;
                toolStripStatusLabel1.Text = "система останавливается по аварии...";
                Stage = 0;
                form1.Send2ModbusFun10(17, 0); // ОТКЛ
            }
            else
            {
                labelAvaria.Visible = false;
                buttonReset.Visible = false;
            }

            if (form1.Regs.HLW == 1)
            {
                lHLW.Text = "Работа Вкл";
                lHLW.Enabled = true;
            }
            else
            {
                lHLW.Text = "Работа Откл";
                lHLW.Enabled = false;
            }

            //// работаем по циклам
            switch (Stage)
            {
                case 1: // 1. Нагрев формалина.
                    if ((form1.Regs.State & 4) != 0)
                    {
                        Stage = 2;
                        progressBarFormalin.Maximum = dateTimePickerFormalin.Value.Hour * 60 * 60 
                            + dateTimePickerFormalin.Value.Minute * 60 
                            + dateTimePickerFormalin.Value.Second;
                        progressBarFormalin.Value = 0;
                        progressBarFormalin.Step = 1;

                    }
                    toolStripStatusLabel1.Text = "Ждем нагрева формалина..."+ RotateImg();
                    break;
                case 2: // 2. Испарение формалина.
                    dateTimePickerFormalin.Value = dateTimePickerFormalin.Value.Subtract(new TimeSpan(0,0,1));
                    progressBarFormalin.PerformStep();
                    if (dateTimePickerFormalin.Value.Hour == 0
                        && dateTimePickerFormalin.Value.Minute == 0
                        && dateTimePickerFormalin.Value.Second == 0
                        )
                    {
                        Stage = 3;
                        progressBarWating.Maximum = dateTimePickerWait.Value.Hour * 60 * 60
                            + dateTimePickerWait.Value.Minute * 60
                            + dateTimePickerWait.Value.Second;
                        progressBarWating.Value = 0;
                        progressBarWating.Step = 1;
                        
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
                        Stage = 4;
                        form1.Send2ModbusFun10(18, 0);//ammiac
                    }

                    toolStripStatusLabel1.Text = "Выдержка..." + RotateImg();
                    break;
                case 4: // 4. Нагрев аммиака.
                    if ((form1.Regs.State & 8) != 0)
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

                    toolStripStatusLabel1.Text = "Испарение аммиака..." + RotateImg();
                    progressBarAmmiac.PerformStep();
                    dateTimePickerAmmiac.Value = dateTimePickerAmmiac.Value.Subtract(new TimeSpan(0, 0, 1));
                    if (dateTimePickerAmmiac.Value.Hour == 0
                        && dateTimePickerAmmiac.Value.Minute == 0
                        && dateTimePickerAmmiac.Value.Second == 0
                        )
                    {
                        Stage = 0;
                        toolStripStatusLabel1.Text = "Испарение аммиака завершено. ОТКЛ. Мoжно жать [STOP]";
                        form1.Send2ModbusFun10(17, 0);
                        
                    }
                    
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
                button1.Text = "STOP";
                //form1.Send2ModbusFun3();
                form1.Send2ModbusFun10(17, 1); // ВКЛ
                timer1.Start();
                toolStripStatusLabel1.Text = "запуск алгоритма";
                form1.Send2ModbusFun10(18, 1);//формалин.
                button2.Enabled = false;


            }
            else
            {

                button1.Text = "START";
                timer1.Stop();
                //form1.btnDisconnect_Click(sender, e);
                //form1.timer.Stop();
                toolStripStatusLabel1.Text = "останов алгоритма";
                button2.Enabled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            form1.Send2ModbusFun10(24, 1);
            Stage = 1;
            //        form1.Send2ModbusFun3();
            //        form1.btnDisconnect_Click(sender,e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelUTEhi.Text = form1.Regs.UTEhi.ToString();

            lTE1.Text = form1.lTE1.Text;
            lTE2.Text = form1.lTE2.Text;

        }
    }
}
