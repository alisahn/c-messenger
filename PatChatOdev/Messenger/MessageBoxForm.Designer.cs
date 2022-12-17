
namespace Messenger
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.stateLabel = new LollipopLabel();
            this.acceptButton = new LollipopButton();
            this.pictureBoxTick = new System.Windows.Forms.PictureBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.dangerButton = new LollipopButton();
            this.pictureBoxDanger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDanger)).BeginInit();
            this.SuspendLayout();
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stateLabel.ForeColor = System.Drawing.Color.Gold;
            this.stateLabel.Location = new System.Drawing.Point(90, 115);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 21);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "State";
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Transparent;
            this.acceptButton.BGColor = "#FFC107";
            this.acceptButton.FontColor = "#ffffff";
            this.acceptButton.Location = new System.Drawing.Point(87, 174);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(125, 37);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // pictureBoxTick
            // 
            this.pictureBoxTick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTick.Image")));
            this.pictureBoxTick.Location = new System.Drawing.Point(31, 98);
            this.pictureBoxTick.Name = "pictureBoxTick";
            this.pictureBoxTick.Size = new System.Drawing.Size(52, 47);
            this.pictureBoxTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTick.TabIndex = 2;
            this.pictureBoxTick.TabStop = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 37);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(69, 20);
            this.lollipopLabel1.TabIndex = 3;
            this.lollipopLabel1.Text = "PatChat";
            // 
            // dangerButton
            // 
            this.dangerButton.BackColor = System.Drawing.Color.Transparent;
            this.dangerButton.BGColor = "#FFC107";
            this.dangerButton.FontColor = "#ffffff";
            this.dangerButton.Location = new System.Drawing.Point(87, 171);
            this.dangerButton.Name = "dangerButton";
            this.dangerButton.Size = new System.Drawing.Size(125, 40);
            this.dangerButton.TabIndex = 4;
            this.dangerButton.Text = "Tamam";
            this.dangerButton.Click += new System.EventHandler(this.dangerButton_Click);
            // 
            // pictureBoxDanger
            // 
            this.pictureBoxDanger.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDanger.Image")));
            this.pictureBoxDanger.Location = new System.Drawing.Point(19, 98);
            this.pictureBoxDanger.Name = "pictureBoxDanger";
            this.pictureBoxDanger.Size = new System.Drawing.Size(64, 54);
            this.pictureBoxDanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDanger.TabIndex = 5;
            this.pictureBoxDanger.TabStop = false;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 234);
            this.Controls.Add(this.pictureBoxDanger);
            this.Controls.Add(this.dangerButton);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.pictureBoxTick);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.stateLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopLabel stateLabel;
        private LollipopButton acceptButton;
        private System.Windows.Forms.PictureBox pictureBoxTick;
        private LollipopLabel lollipopLabel1;
        private LollipopButton dangerButton;
        private System.Windows.Forms.PictureBox pictureBoxDanger;
    }
}