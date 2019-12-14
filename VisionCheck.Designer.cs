namespace GoodVision
{
    partial class VisionCheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionCheck));
            this.BluePanel = new System.Windows.Forms.Panel();
            this.DarkPanel = new System.Windows.Forms.Panel();
            this.InstrLabel = new System.Windows.Forms.Label();
            this.AdviceLabel = new System.Windows.Forms.Label();
            this.VisionCheckLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.sivtsevTip = new System.Windows.Forms.ToolTip(this.components);
            this.SivtsevModeButton = new TetraCustomButton.ImageTetraButton();
            this.LandoltTip = new System.Windows.Forms.ToolTip(this.components);
            this.LandoltModeButton = new TetraCustomButton.ImageTetraButton();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.BluePanel.SuspendLayout();
            this.DarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BluePanel
            // 
            this.BluePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BluePanel.BackColor = System.Drawing.Color.Transparent;
            this.BluePanel.BackgroundImage = global::GoodVision.Properties.Resources.BlueBack1;
            this.BluePanel.Controls.Add(this.DarkPanel);
            this.BluePanel.Controls.Add(this.AdviceLabel);
            this.BluePanel.Controls.Add(this.VisionCheckLabel);
            this.BluePanel.Controls.Add(this.InstructionLabel);
            this.BluePanel.ForeColor = System.Drawing.Color.White;
            this.BluePanel.Location = new System.Drawing.Point(0, -1);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(1144, 416);
            this.BluePanel.TabIndex = 0;
            // 
            // DarkPanel
            // 
            this.DarkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkPanel.BackgroundImage = global::GoodVision.Properties.Resources.подложка2;
            this.DarkPanel.Controls.Add(this.InstrLabel);
            this.DarkPanel.Location = new System.Drawing.Point(3, 160);
            this.DarkPanel.Name = "DarkPanel";
            this.DarkPanel.Size = new System.Drawing.Size(1124, 127);
            this.DarkPanel.TabIndex = 2;
            // 
            // InstrLabel
            // 
            this.InstrLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstrLabel.AutoSize = true;
            this.InstrLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstrLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstrLabel.Location = new System.Drawing.Point(105, 11);
            this.InstrLabel.Name = "InstrLabel";
            this.InstrLabel.Size = new System.Drawing.Size(1225, 126);
            this.InstrLabel.TabIndex = 0;
            this.InstrLabel.Text = resources.GetString("InstrLabel.Text");
            this.InstrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdviceLabel
            // 
            this.AdviceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AdviceLabel.AutoSize = true;
            this.AdviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdviceLabel.Location = new System.Drawing.Point(231, 297);
            this.AdviceLabel.Name = "AdviceLabel";
            this.AdviceLabel.Size = new System.Drawing.Size(818, 32);
            this.AdviceLabel.TabIndex = 1;
            this.AdviceLabel.Text = "Щоб обрати формат тестування нажмiть на зображення.";
            this.AdviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisionCheckLabel
            // 
            this.VisionCheckLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VisionCheckLabel.AutoSize = true;
            this.VisionCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.VisionCheckLabel.Font = new System.Drawing.Font("a_AvanteInt", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisionCheckLabel.Location = new System.Drawing.Point(471, 31);
            this.VisionCheckLabel.Name = "VisionCheckLabel";
            this.VisionCheckLabel.Size = new System.Drawing.Size(307, 69);
            this.VisionCheckLabel.TabIndex = 0;
            this.VisionCheckLabel.Text = "Почнемо!";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionLabel.Location = new System.Drawing.Point(152, 104);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(1037, 39);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Для початку тестування вам необхідно обрати його формат.";
            this.InstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sivtsevTip
            // 
            this.sivtsevTip.IsBalloon = true;
            // 
            // SivtsevModeButton
            // 
            this.SivtsevModeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SivtsevModeButton.Image = global::GoodVision.Properties.Resources.SivtsevHover;
            this.SivtsevModeButton.ImageHover = global::GoodVision.Properties.Resources.civtsev;
            this.SivtsevModeButton.ImageNormal = global::GoodVision.Properties.Resources.SivtsevHover;
            this.SivtsevModeButton.Location = new System.Drawing.Point(612, 330);
            this.SivtsevModeButton.Name = "SivtsevModeButton";
            this.SivtsevModeButton.Size = new System.Drawing.Size(346, 241);
            this.SivtsevModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SivtsevModeButton.TabIndex = 4;
            this.SivtsevModeButton.TabStop = false;
            this.sivtsevTip.SetToolTip(this.SivtsevModeButton, "Тестування за допомоги таблиці Сивцева");
            this.SivtsevModeButton.Click += new System.EventHandler(this.SivtsevModeButton_Click);
            // 
            // LandoltTip
            // 
            this.LandoltTip.IsBalloon = true;
            // 
            // LandoltModeButton
            // 
            this.LandoltModeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LandoltModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LandoltModeButton.Image = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.Image")));
            this.LandoltModeButton.ImageHover = global::GoodVision.Properties.Resources.LandoltHover;
            this.LandoltModeButton.ImageNormal = ((System.Drawing.Image)(resources.GetObject("LandoltModeButton.ImageNormal")));
            this.LandoltModeButton.Location = new System.Drawing.Point(253, 330);
            this.LandoltModeButton.Name = "LandoltModeButton";
            this.LandoltModeButton.Size = new System.Drawing.Size(327, 241);
            this.LandoltModeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LandoltModeButton.TabIndex = 3;
            this.LandoltModeButton.TabStop = false;
            this.LandoltTip.SetToolTip(this.LandoltModeButton, "Тестування за допомоги кілець Ландольта");
            this.LandoltModeButton.Click += new System.EventHandler(this.LandoltModeButton_Click_1);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackToMenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.Image = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToMenuButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToMenuButton.Location = new System.Drawing.Point(12, 460);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(218, 163);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // VisionCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 635);
            this.Controls.Add(this.LandoltModeButton);
            this.Controls.Add(this.SivtsevModeButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.BluePanel);
            this.DoubleBuffered = true;
            this.Name = "VisionCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisionCheck";
            this.BluePanel.ResumeLayout(false);
            this.BluePanel.PerformLayout();
            this.DarkPanel.ResumeLayout(false);
            this.DarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SivtsevModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandoltModeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Label VisionCheckLabel;
        private System.Windows.Forms.Label InstructionLabel;
     //   private ImageTetraButton.ImageCustomButton SivtsevModeButton;
       // private ImageTetraButton.ImageCustomButton LandoltModeButton;
    //    private rbutton.CustRoundButton BackFromVChButton;
        private System.Windows.Forms.Label InstrLabel;
        private rbutton.CustRoundButton BackToMenuButton;
        private TetraCustomButton.ImageTetraButton LandoltModeButton;
        private TetraCustomButton.ImageTetraButton SivtsevModeButton;
        private System.Windows.Forms.ToolTip sivtsevTip;
        private System.Windows.Forms.ToolTip LandoltTip;
        private System.Windows.Forms.Panel DarkPanel;
        private System.Windows.Forms.Label AdviceLabel;
    }
}