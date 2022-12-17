using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Messenger
{
    public partial class frmMain : MaterialForm
    {
       
        Socket sck;
        EndPoint epLocal, epFriend;
        byte[] buffer;
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager menager = MaterialSkinManager.Instance;
            menager.AddFormToManage(this);
            menager.Theme = MaterialSkinManager.Themes.LIGHT;
            menager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.Amber700, Primary.Amber500, Accent.Amber400, TextShade.WHITE);
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalip.Text = GetLocalIp();
            textFriendip.Text = GetLocalIp();
            lblUser1.Text = Login.username;
            lblUsername.Text = Login.username;

            if (Application.OpenForms["onl"] == null)
            {
                lblShowOnline.Enabled = true;

            }
            else if (Application.OpenForms["onl"] != null)
            {
                lblShowOnline.Enabled = false; 
            }
        } 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalip.Text), Convert.ToInt32(textLocalport.Text));
                sck.Bind(epLocal);

                epFriend = new IPEndPoint(IPAddress.Parse(textFriendip.Text), Convert.ToInt32(textFriendport.Text));
                sck.Connect(epFriend);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epFriend, new AsyncCallback(MessageCallBack), buffer);
                buttonStart.Text = "Bağlandı";
                buttonStart.Enabled = false;
                buttonSend.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }  
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult,ref epFriend);
                if (size>0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recievedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add(recievedMessage);
                }
                byte []buffer = new byte [1500];
                sck.BeginReceiveFrom(buffer,0,buffer.Length,SocketFlags.None,ref epFriend, new AsyncCallback(MessageCallBack),buffer);
            }
            catch (Exception exp)
            {
               
                MessageBox.Show(exp.ToString());
            }
        }

       /* private void buttonSend_Click(object sender, EventArgs e)
        {
            //mesajı byte a çevir
           // ASCIIEncoding aEncoding = new ASCIIEncoding();
           // byte[] sendMessage = new byte[1500];
           // sendMessage = aEncoding.GetBytes(textMessage.Text);

            //mesajı gmnder
           // sck.Send(sendMessage);

           // listMessage.Items.Add("ben : " + textMessage.Text);
            //textMessage.Text = "gitti";
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(lblUsername.Text +": "+textMessage.Text);

                sck.Send(msg) ;
                listMessage.Items.Add(Login.username+ " : " + textMessage.Text);
                textMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }*/

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalip.Text), Convert.ToInt32(textLocalport.Text));
                sck.Bind(epLocal);

                epFriend = new IPEndPoint(IPAddress.Parse(textFriendip.Text), Convert.ToInt32(textFriendport.Text));
                sck.Connect(epFriend);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epFriend, new AsyncCallback(MessageCallBack), buffer);
                buttonStart.Text = "Bağlandı";
                buttonStart.Enabled = false;
                buttonSend.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(lblUsername.Text + ": " + textMessage.Text+" " + DateTime.Now.ToString("H:mm"));
                 sck.Send(msg);

                listMessage.Items.Add("Ben : " + textMessage.Text+" " + DateTime.Now.ToString("H:mm"));
                textMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lollipopLabel7_Click(object sender, EventArgs e)
        {//close label alanım
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE user Set state = '0' WHERE kullanici_adi= @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = lblUsername.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            Application.Exit();
        }

        private void tglState_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (tglState.Checked == true)
            {
               
                MySqlCommand command = new MySqlCommand("UPDATE user Set state = '1' WHERE kullanici_adi= @usn", db.getConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value =lblUsername.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            if (tglState.Checked == false)
            {
                MySqlCommand command = new MySqlCommand("UPDATE user Set state = '0' WHERE kullanici_adi= @usn", db.getConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = lblUsername.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
        }
        
        private void lblShowOnline_Click(object sender, EventArgs e)
        {
            onlineMain onl = new onlineMain();
            onl.Show();
           

        }

        private void listMessage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listMessage.Items.Remove(listMessage.SelectedItem);
        }

        private void textMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
} }
