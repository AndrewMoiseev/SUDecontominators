using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace SUDecontominators
{
    public class Settin
    {

       // private String dbFileName;
 //       private SQLiteConnection m_dbConn;
 //       private SQLiteCommand m_sqlCmd;

        /// <summary>
        /// номер системы
        /// </summary>
        public int SystemNumber;
        /// <summary>
        /// номер устройства в системе
        /// </summary>
        public int ItemOfSystem;

        public int PollingInterval { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public TimeSpan TimeFormalin { get; set; }
        public TimeSpan TimeAmmiac { get; set; }
        public TimeSpan TimeWaiting { get; set; }

        public Settin(int sysnum, int item, String dbFileName)
        {
            //String sqlQuery;
            try
            {
                //TimeFormalin = new DateTime(0);
                //TimeAmmiac = new DateTime(0);
                //TimeWaiting = new DateTime(0);

                using (SQLiteConnection connect = new SQLiteConnection(@"Data Source="+ dbFileName))
                {
                    connect.Open();
                    using (SQLiteCommand fmd = connect.CreateCommand())
                    {
                        //sqlQuery = @"SELECT * FROM Settings where System=" + sysnum.ToString() + " and Decontaminator = " + item.ToString();
                        fmd.CommandText = @"SELECT * FROM Settings where System=" + sysnum.ToString() + " and Decontaminator = " + item.ToString(); 
                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            IPAddress = (string)r["IPAddress"];
                            Port = Convert.ToInt32(r["Port"]); 
                            PollingInterval = Convert.ToInt32(r["PollingInterval"]);
                            TimeFormalin = new TimeSpan(Convert.ToInt64(r["TimeFormalin"]));
                            TimeAmmiac = new TimeSpan(Convert.ToInt64(r["TimeAmmiac"]));
                            TimeWaiting = new TimeSpan(Convert.ToInt64(r["TimeWaiting"]));

                        }

                        connect.Close();
                    }
                }           
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                IPAddress = "localhost";
                Port = 502;
                PollingInterval = 4;

            }
        }
    }
}
