using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class onlineMain : MaterialForm
    {
        private int _tick;
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306" +
          ";username=root; password=;database=patchat");
        public onlineMain()
        {
            InitializeComponent();
           
            timer1.Interval = 1000;
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            listUsers.Items.Clear();
            listUserOffline.Items.Clear();
            connection.Open();
            string komut1 = "SELECT * FROM user WHERE state ='1'";
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(komut1, connection);
            MySqlDataReader datalarım1 = myCommand.ExecuteReader();

            while (datalarım1.Read())
            {

                listUsers.Items.Add(datalarım1["kullanici_adi"].ToString() + "  port : " + datalarım1["port"].ToString());
                listUsers.ForeColor = Color.Green;
            }
            connection.Close();
            connection.Open();
            string komut2 = "SELECT * FROM user WHERE state ='0'";
            MySql.Data.MySqlClient.MySqlCommand myCommandd = new MySql.Data.MySqlClient.MySqlCommand(komut2, connection);
            MySqlDataReader datalarım2 = myCommandd.ExecuteReader();

            while (datalarım2.Read())
            {

                listUserOffline.Items.Add(datalarım2["kullanici_adi"].ToString() + "  port : " + datalarım2["port"].ToString());
                listUserOffline.ForeColor = Color.Red;
            }
            connection.Close();
            
        }
    }
}
