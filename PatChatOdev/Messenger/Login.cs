using MaterialSkin;
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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            MaterialSkinManager menager = MaterialSkinManager.Instance;
            menager.AddFormToManage(this);
            menager.Theme = MaterialSkinManager.Themes.LIGHT;
            menager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.Amber700, Primary.Amber500, Accent.Amber400, TextShade.WHITE);
            InitializeComponent();
           
            this.txtPwd.Size = new Size(this.txtPwd.Size.Width, 50);
            this.ActiveControl= txtUser;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static string username;
        public static string pwd;
        public static int state = 0;

        private void loginBtn_Click(object sender, EventArgs e)
        {
             DB db = new DB();
             username = txtUser.Text;
             pwd = txtPwd.Text;
             DataTable table = new DataTable();
             MySqlDataAdapter adapter = new MySqlDataAdapter();
             MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE kullanici_adi= @usn and kullanici_password = @pass", db.getConnection());
             command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
             command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd;

             adapter.SelectCommand = command;
             adapter.Fill(table);

             if (table.Rows.Count==1)
             {

                MessageBox.Show("Hoşgeldin "+username, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                state = 1;
                frmMain frm = new frmMain();
                frm.Show();
                /*/ 
                 MessageBoxForm mbf = new MessageBoxForm();
                 mbf.Show();*/

                //

            }
            else
             {
                state = 0;
                MessageBoxForm mbf = new MessageBoxForm();
                mbf.Show();
             }
            this.Hide();

        }
    }
}
