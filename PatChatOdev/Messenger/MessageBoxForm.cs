using MaterialSkin.Controls;
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
    public partial class MessageBoxForm : MaterialForm
    {

        private int state = Login.state;

        public MessageBoxForm()
        {
            InitializeComponent();
            if (state == 1)
            {
                pictureBoxDanger.Visible = false;
                dangerButton.Visible = false;
                dangerButton.Enabled = false;
                stateLabel.Text = "Hoş geldin " + Login.username;
                stateLabel.ForeColor = Color.Green;
            }
            else
            {
                pictureBoxTick.Visible = false;
                acceptButton.Visible = false;
                acceptButton.Enabled = false;
                stateLabel.Text = "Giriş Başarısız !";
                stateLabel.ForeColor = Color.Red;
            }
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
           
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void dangerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.Show();
            
        }
    }
}
