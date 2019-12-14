namespace GoodVision
{
    partial class RegMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.NoButton = new ButtonRoundedCorners.RoundedCorners();
            this.YesButton = new ButtonRoundedCorners.RoundedCorners();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = global::GoodVision.Properties.Resources.подложка;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Акаунт з таким логіном\r\n вже створено. \r\nЦе ваш акаунт?";
            // 
            // NoButton
            // 
            this.NoButton.Image = ((System.Drawing.Image)(resources.GetObject("NoButton.Image")));
            this.NoButton.ImageHover = global::GoodVision.Properties.Resources.NoHover;
            this.NoButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("NoButton.ImageNormal")));
            this.NoButton.Location = new System.Drawing.Point(287, 170);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(114, 51);
            this.NoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NoButton.TabIndex = 2;
            this.NoButton.TabStop = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Image = global::GoodVision.Properties.Resources.Yes;
            this.YesButton.ImageHover = global::GoodVision.Properties.Resources.YesHover;
            this.YesButton.ImageNormal = global::GoodVision.Properties.Resources.Yes;
            this.YesButton.Location = new System.Drawing.Point(109, 170);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(114, 51);
            this.YesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.YesButton.TabIndex = 1;
            this.YesButton.TabStop = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 147);
            this.panel1.TabIndex = 3;
            // 
            // RegMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::GoodVision.Properties.Resources.подложка2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegMessage";
            ((System.ComponentModel.ISupportInitialize)(this.NoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YesButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ButtonRoundedCorners.RoundedCorners YesButton;
        private ButtonRoundedCorners.RoundedCorners NoButton;
        private System.Windows.Forms.Panel panel1;
        //  private RoundedButton.MyRoundButton YesButton;
        //   private RoundButtonTwo.MyRoundButton NoButton;
    }
}