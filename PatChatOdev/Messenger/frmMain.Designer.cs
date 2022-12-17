
namespace Messenger
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainContainer = new System.Windows.Forms.Panel();
            this.lblShowOnline = new LollipopLabel();
            this.tglState = new LollipopToggle();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.textFriendport = new LollipopTextBox();
            this.textFriendip = new LollipopTextBox();
            this.buttonSend = new LollipopButton();
            this.buttonStart = new LollipopButton();
            this.lollipopLabel2 = new LollipopLabel();
            this.lblUser2 = new LollipopLabel();
            this.lblUser1 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.textLocalport = new LollipopTextBox();
            this.textLocalip = new LollipopTextBox();
            this.lblUsername = new LollipopLabel();
            this.lblCloseApp = new LollipopLabel();
            this.isim = new LollipopLabel();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Controls.Add(this.lblShowOnline);
            this.MainContainer.Controls.Add(this.tglState);
            this.MainContainer.Controls.Add(this.listMessage);
            this.MainContainer.Controls.Add(this.textMessage);
            this.MainContainer.Controls.Add(this.lollipopLabel5);
            this.MainContainer.Controls.Add(this.lollipopLabel6);
            this.MainContainer.Controls.Add(this.textFriendport);
            this.MainContainer.Controls.Add(this.textFriendip);
            this.MainContainer.Controls.Add(this.buttonSend);
            this.MainContainer.Controls.Add(this.buttonStart);
            this.MainContainer.Controls.Add(this.lollipopLabel2);
            this.MainContainer.Controls.Add(this.lblUser2);
            this.MainContainer.Controls.Add(this.lblUser1);
            this.MainContainer.Controls.Add(this.lollipopLabel1);
            this.MainContainer.Controls.Add(this.textLocalport);
            this.MainContainer.Controls.Add(this.textLocalip);
            this.MainContainer.Location = new System.Drawing.Point(12, 77);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(836, 510);
            this.MainContainer.TabIndex = 0;
            // 
            // lblShowOnline
            // 
            this.lblShowOnline.AutoSize = true;
            this.lblShowOnline.BackColor = System.Drawing.Color.Transparent;
            this.lblShowOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblShowOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblShowOnline.Location = new System.Drawing.Point(675, 57);
            this.lblShowOnline.Name = "lblShowOnline";
            this.lblShowOnline.Size = new System.Drawing.Size(127, 20);
            this.lblShowOnline.TabIndex = 25;
            this.lblShowOnline.Text = "Kullanıcı Listesi";
            this.lblShowOnline.Click += new System.EventHandler(this.lblShowOnline_Click);
            // 
            // tglState
            // 
            this.tglState.AutoSize = true;
            this.tglState.EllipseBorderColor = "#FFC107";
            this.tglState.EllipseColor = "#FFC107";
            this.tglState.Location = new System.Drawing.Point(109, 18);
            this.tglState.Name = "tglState";
            this.tglState.Size = new System.Drawing.Size(47, 19);
            this.tglState.TabIndex = 24;
            this.tglState.Text = "lollipopToggle1";
            this.tglState.UseVisualStyleBackColor = true;
            this.tglState.CheckedChanged += new System.EventHandler(this.tglState_CheckedChanged);
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.Info;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(26, 147);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(789, 292);
            this.listMessage.TabIndex = 23;
            this.listMessage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listMessage_MouseDoubleClick);
            // 
            // textMessage
            // 
            this.textMessage.FocusedColor = "#FFC107";
            this.textMessage.FontColor = "#999999";
            this.textMessage.IsEnabled = true;
            this.textMessage.Location = new System.Drawing.Point(26, 469);
            this.textMessage.MaxLength = 32767;
            this.textMessage.Multiline = false;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = false;
            this.textMessage.Size = new System.Drawing.Size(625, 24);
            this.textMessage.TabIndex = 22;
            this.textMessage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textMessage.UseSystemPasswordChar = false;
            this.textMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textMessage_KeyUp);
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.Orange;
            this.lollipopLabel5.Location = new System.Drawing.Point(367, 99);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(50, 20);
            this.lollipopLabel5.TabIndex = 20;
            this.lollipopLabel5.Text = "Port :";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.Orange;
            this.lollipopLabel6.Location = new System.Drawing.Point(367, 53);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(55, 20);
            this.lollipopLabel6.TabIndex = 21;
            this.lollipopLabel6.Text = "Host :";
            // 
            // textFriendport
            // 
            this.textFriendport.FocusedColor = "#FFC107";
            this.textFriendport.FontColor = "#999999";
            this.textFriendport.IsEnabled = true;
            this.textFriendport.Location = new System.Drawing.Point(449, 95);
            this.textFriendport.MaxLength = 32767;
            this.textFriendport.Multiline = false;
            this.textFriendport.Name = "textFriendport";
            this.textFriendport.ReadOnly = false;
            this.textFriendport.Size = new System.Drawing.Size(146, 24);
            this.textFriendport.TabIndex = 18;
            this.textFriendport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textFriendport.UseSystemPasswordChar = false;
            // 
            // textFriendip
            // 
            this.textFriendip.FocusedColor = "#FFC107";
            this.textFriendip.FontColor = "#999999";
            this.textFriendip.IsEnabled = true;
            this.textFriendip.Location = new System.Drawing.Point(449, 53);
            this.textFriendip.MaxLength = 32767;
            this.textFriendip.Multiline = false;
            this.textFriendip.Name = "textFriendip";
            this.textFriendip.ReadOnly = false;
            this.textFriendip.Size = new System.Drawing.Size(146, 24);
            this.textFriendip.TabIndex = 19;
            this.textFriendip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textFriendip.UseSystemPasswordChar = false;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.BGColor = "#FFC107";
            this.buttonSend.FontColor = "#ffffff";
            this.buttonSend.Location = new System.Drawing.Point(679, 459);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(136, 34);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Gönder";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BGColor = "#FFC107";
            this.buttonStart.FontColor = "#ffffff";
            this.buttonStart.Location = new System.Drawing.Point(679, 95);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(127, 24);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "Başlat";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.Orange;
            this.lollipopLabel2.Location = new System.Drawing.Point(22, 99);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(50, 20);
            this.lollipopLabel2.TabIndex = 12;
            this.lollipopLabel2.Text = "Port :";
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.BackColor = System.Drawing.Color.Transparent;
            this.lblUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblUser2.Location = new System.Drawing.Point(367, 17);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(81, 20);
            this.lblUser2.TabIndex = 13;
            this.lblUser2.Text = "Kullanıcı2";
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.BackColor = System.Drawing.Color.Transparent;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblUser1.Location = new System.Drawing.Point(22, 17);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(81, 20);
            this.lblUser1.TabIndex = 14;
            this.lblUser1.Text = "Kullanıcı1";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.Orange;
            this.lollipopLabel1.Location = new System.Drawing.Point(22, 53);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(55, 20);
            this.lollipopLabel1.TabIndex = 15;
            this.lollipopLabel1.Text = "Host :";
            // 
            // textLocalport
            // 
            this.textLocalport.FocusedColor = "#FFC107";
            this.textLocalport.FontColor = "#999999";
            this.textLocalport.IsEnabled = true;
            this.textLocalport.Location = new System.Drawing.Point(104, 95);
            this.textLocalport.MaxLength = 32767;
            this.textLocalport.Multiline = false;
            this.textLocalport.Name = "textLocalport";
            this.textLocalport.ReadOnly = false;
            this.textLocalport.Size = new System.Drawing.Size(148, 24);
            this.textLocalport.TabIndex = 10;
            this.textLocalport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textLocalport.UseSystemPasswordChar = false;
            // 
            // textLocalip
            // 
            this.textLocalip.FocusedColor = "#FFC107";
            this.textLocalip.FontColor = "#999999";
            this.textLocalip.IsEnabled = true;
            this.textLocalip.Location = new System.Drawing.Point(104, 53);
            this.textLocalip.MaxLength = 32767;
            this.textLocalip.Multiline = false;
            this.textLocalip.Name = "textLocalip";
            this.textLocalip.ReadOnly = false;
            this.textLocalip.Size = new System.Drawing.Size(148, 24);
            this.textLocalip.TabIndex = 11;
            this.textLocalip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textLocalip.UseSystemPasswordChar = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Agency FB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(112, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 31);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "sadsa";
            // 
            // lblCloseApp
            // 
            this.lblCloseApp.AutoSize = true;
            this.lblCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCloseApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblCloseApp.Location = new System.Drawing.Point(803, 33);
            this.lblCloseApp.Name = "lblCloseApp";
            this.lblCloseApp.Size = new System.Drawing.Size(45, 20);
            this.lblCloseApp.TabIndex = 2;
            this.lblCloseApp.Text = "  X   ";
            this.lblCloseApp.Click += new System.EventHandler(this.lollipopLabel7_Click);
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.BackColor = System.Drawing.Color.Transparent;
            this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.isim.Location = new System.Drawing.Point(127, 33);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(0, 20);
            this.isim.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 599);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCloseApp);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.MainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatChat";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.ListBox listMessage;
        private LollipopTextBox textMessage;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel6;
        private LollipopTextBox textFriendport;
        private LollipopTextBox textFriendip;
        private LollipopButton buttonSend;
        private LollipopButton buttonStart;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lblUser2;
        private LollipopLabel lblUser1;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox textLocalport;
        private LollipopTextBox textLocalip;
        private LollipopLabel isim;
        private LollipopLabel lblCloseApp;
        private LollipopLabel lblUsername;
        private LollipopToggle tglState;
        private LollipopLabel lblShowOnline;
    }
}

