
namespace Messenger
{
    partial class onlineMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onlineMain));
            this.listUsers = new System.Windows.Forms.ListBox();
            this.listUserOffline = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOnline = new LollipopLabel();
            this.lblOfflinw = new LollipopLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUsers.ForeColor = System.Drawing.Color.Turquoise;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 20;
            this.listUsers.Location = new System.Drawing.Point(12, 109);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(183, 444);
            this.listUsers.TabIndex = 1;
            // 
            // listUserOffline
            // 
            this.listUserOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUserOffline.ForeColor = System.Drawing.Color.Turquoise;
            this.listUserOffline.FormattingEnabled = true;
            this.listUserOffline.ItemHeight = 20;
            this.listUserOffline.Location = new System.Drawing.Point(201, 109);
            this.listUserOffline.Name = "listUserOffline";
            this.listUserOffline.Size = new System.Drawing.Size(183, 444);
            this.listUserOffline.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.BackColor = System.Drawing.Color.Transparent;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOnline.ForeColor = System.Drawing.Color.Lime;
            this.lblOnline.Location = new System.Drawing.Point(47, 86);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(57, 20);
            this.lblOnline.TabIndex = 2;
            this.lblOnline.Text = "Online";
            // 
            // lblOfflinw
            // 
            this.lblOfflinw.AutoSize = true;
            this.lblOfflinw.BackColor = System.Drawing.Color.Transparent;
            this.lblOfflinw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOfflinw.ForeColor = System.Drawing.Color.Crimson;
            this.lblOfflinw.Location = new System.Drawing.Point(239, 86);
            this.lblOfflinw.Name = "lblOfflinw";
            this.lblOfflinw.Size = new System.Drawing.Size(58, 20);
            this.lblOfflinw.TabIndex = 2;
            this.lblOfflinw.Text = "Offline";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(201, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // onlineMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(396, 555);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOfflinw);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.listUserOffline);
            this.Controls.Add(this.listUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "onlineMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.ListBox listUserOffline;
        private System.Windows.Forms.Timer timer1;
        private LollipopLabel lblOnline;
        private LollipopLabel lblOfflinw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
