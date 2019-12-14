namespace GoodVision
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lightPanel = new System.Windows.Forms.Panel();
            this.HelloLab = new System.Windows.Forms.Label();
            this.darkPanel = new System.Windows.Forms.Panel();
            this.VisionCheckButton = new ButtonRoundedCorners.RoundedCorners();
            this.StaticticButton = new ButtonRoundedCorners.RoundedCorners();
            this.HelpButton = new rbutton.CustRoundButton();
            this.eyePictureBox = new System.Windows.Forms.PictureBox();
            this.ChangeUser = new TetraCustomButton.ImageTetraButton();
            this.lightPanel.SuspendLayout();
            this.darkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaticticButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lightPanel
            // 
            this.lightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lightPanel.BackColor = System.Drawing.Color.Transparent;
            this.lightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lightPanel.BackgroundImage")));
            this.lightPanel.Controls.Add(this.HelloLab);
            this.lightPanel.Location = new System.Drawing.Point(182, 41);
            this.lightPanel.Name = "lightPanel";
            this.lightPanel.Size = new System.Drawing.Size(772, 134);
            this.lightPanel.TabIndex = 1;
            // 
            // HelloLab
            // 
            this.HelloLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelloLab.AutoSize = true;
            this.HelloLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.HelloLab.Location = new System.Drawing.Point(16, 22);
            this.HelloLab.Name = "HelloLab";
            this.HelloLab.Size = new System.Drawing.Size(341, 87);
            this.HelloLab.TabIndex = 0;
            this.HelloLab.Text = "Вітаємо,";
            // 
            // darkPanel
            // 
            this.darkPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.darkPanel.BackColor = System.Drawing.Color.Transparent;
            this.darkPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("darkPanel.BackgroundImage")));
            this.darkPanel.Controls.Add(this.VisionCheckButton);
            this.darkPanel.Controls.Add(this.StaticticButton);
            this.darkPanel.Location = new System.Drawing.Point(182, 250);
            this.darkPanel.Name = "darkPanel";
            this.darkPanel.Size = new System.Drawing.Size(772, 323);
            this.darkPanel.TabIndex = 2;
            // 
            // VisionCheckButton
            // 
            this.VisionCheckButton.BackColor = System.Drawing.Color.Coral;
            this.VisionCheckButton.BackgroundImage = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.Image = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.ImageHover = global::GoodVision.Properties.Resources.почТестHover;
            this.VisionCheckButton.ImageNormal = global::GoodVision.Properties.Resources.початиТест;
            this.VisionCheckButton.Location = new System.Drawing.Point(65, 187);
            this.VisionCheckButton.Name = "VisionCheckButton";
            this.VisionCheckButton.Size = new System.Drawing.Size(668, 93);
            this.VisionCheckButton.TabIndex = 3;
            this.VisionCheckButton.TabStop = false;
            this.VisionCheckButton.Click += new System.EventHandler(this.VisionCheckButton_Click);
            // 
            // StaticticButton
            // 
            this.StaticticButton.BackColor = System.Drawing.Color.Coral;
            this.StaticticButton.BackgroundImage = global::GoodVision.Properties.Resources.statistic;
            this.StaticticButton.ImageHover = global::GoodVision.Properties.Resources.стат;
            this.StaticticButton.ImageNormal = null;
            this.StaticticButton.Location = new System.Drawing.Point(65, 47);
            this.StaticticButton.Name = "StaticticButton";
            this.StaticticButton.Size = new System.Drawing.Size(668, 93);
            this.StaticticButton.TabIndex = 2;
            this.StaticticButton.TabStop = false;
            this.StaticticButton.Click += new System.EventHandler(this.StaticticButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelpButton.Image = global::GoodVision.Properties.Resources.NewHelp;
            this.HelpButton.ImageHover = global::GoodVision.Properties.Resources.NewHelpHover;
            this.HelpButton.ImageNormal = global::GoodVision.Properties.Resources.NewHelp;
            this.HelpButton.Location = new System.Drawing.Point(1006, 462);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(122, 111);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // eyePictureBox
            // 
            this.eyePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eyePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.eyePictureBox.Image = global::GoodVision.Properties.Resources.eye1;
            this.eyePictureBox.Location = new System.Drawing.Point(25, 63);
            this.eyePictureBox.Name = "eyePictureBox";
            this.eyePictureBox.Size = new System.Drawing.Size(131, 89);
            this.eyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyePictureBox.TabIndex = 4;
            this.eyePictureBox.TabStop = false;
            this.eyePictureBox.MouseEnter += new System.EventHandler(this.eyePictureBox_MouseEnter);
            this.eyePictureBox.MouseLeave += new System.EventHandler(this.eyePictureBox_MouseLeave);
            // 
            // ChangeUser
            // 
            this.ChangeUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeUser.Image = global::GoodVision.Properties.Resources.ChangeUser;
            this.ChangeUser.ImageHover = global::GoodVision.Properties.Resources.ChangeUserHover;
            this.ChangeUser.ImageNormal = global::GoodVision.Properties.Resources.ChangeUser;
            this.ChangeUser.Location = new System.Drawing.Point(971, 60);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(157, 92);
            this.ChangeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChangeUser.TabIndex = 5;
            this.ChangeUser.TabStop = false;
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            // 
            // MainMenu
            // 
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 638);
            this.Controls.Add(this.ChangeUser);
            this.Controls.Add(this.eyePictureBox);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.darkPanel);
            this.Controls.Add(this.lightPanel);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.lightPanel.ResumeLayout(false);
            this.lightPanel.PerformLayout();
            this.darkPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisionCheckButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaticticButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        //    private RoundButtonTwo.MyRoundButton CheckVisionButton;
        // private rbutton.CustRoundButton HelpButton;
        //     private RoundButtonTwo.MyRoundButton StatisticButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel lightPanel;
        private System.Windows.Forms.Panel darkPanel;
        //  private rbutton.CustRoundButton MainMenuHellpButton;
        public System.Windows.Forms.Label HelloLab;

        private rbutton.CustRoundButton HelpButton;
        private ButtonRoundedCorners.RoundedCorners VisionCheckButton;
        private ButtonRoundedCorners.RoundedCorners StaticticButton;
        private System.Windows.Forms.PictureBox eyePictureBox;
        private TetraCustomButton.ImageTetraButton ChangeUser;
        //
    }
}