using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SUDecontominators
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

        }
        public FormSettings(Form1 f)
        {
            InitializeComponent();

            texIP.Text = f.Set.IPAddress;
            textPort.Text = f.Set.Port.ToString();
            var ftime = new DateTime(2018, 10, 18, 0, 0, 0);

            timeFormaline.Value = ftime.Add(f.Set.TimeFormalin);
            timeAmmiac.Value = ftime.Add(f.Set.TimeAmmiac);
            timeWait.Value = ftime.Add(f.Set.TimeWaiting);
            numericUpDownPollingInterval.Value = f.Set.PollingInterval>1? f.Set.PollingInterval:1;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ((Form1)Owner).Set.IPAddress = texIP.Text;
            ((Form1)Owner).Set.Port = Convert.ToInt32( textPort.Text);
            ((Form1)Owner).Set.TimeFormalin = timeFormaline.Value.TimeOfDay;
            ((Form1)Owner).Set.TimeAmmiac = timeAmmiac.Value.TimeOfDay;
            ((Form1)Owner).Set.TimeWaiting = timeWait.Value.TimeOfDay;
            ((Form1)Owner).Set.PollingInterval = Convert.ToInt32(numericUpDownPollingInterval.Value);

            try
            {

                using (SQLiteConnection connect = new SQLiteConnection(@"Data Source=base.sqlite"))
                {
                    connect.Open();
                    using (SQLiteCommand fmd = connect.CreateCommand())
                    {
                        /*
	`System`	INTEGER NOT NULL DEFAULT 1,
	`Decontaminator`	INTEGER NOT NULL DEFAULT 1,
	`IPAddress`	TEXT DEFAULT 'localhost',
	`Port`	INTEGER DEFAULT 502,
	`PollingInterval`	INTEGER DEFAULT 5,
	`TimeFormalin`	INTEGER,
	`TimeAmmiac`	INTEGER,
	`TimeWaiting`	INTEGER,
                         
                         */
                        ////         insert or replace into Settings(...) values
                        ////         (, ...);

                        fmd.CommandText = @"insert or replace into Settings(System,Decontaminator,IPAddress,Port,PollingInterval,TimeFormalin,TimeAmmiac,TimeWaiting) values";
                        fmd.CommandText += "("+ numericUpDownSys.Value.ToString()+","+numericUpDownDec.Value.ToString() + ","
                                              + "'"+ texIP.Text + "',"
                                              + textPort.Text + ","
                                              + numericUpDownPollingInterval.Value.ToString() + ","
                                              + timeFormaline.Value.TimeOfDay.Ticks.ToString() + ","
                                              + timeAmmiac.Value.TimeOfDay.Ticks.ToString() + ","
                                              + timeWait.Value.TimeOfDay.Ticks.ToString() + ");";
                        fmd.ExecuteNonQuery();

                        connect.Close();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

            ////

        }
    }

}