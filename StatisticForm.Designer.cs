namespace GoodVision
{
	partial class StatisticForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.darkPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.StatisticTable = new System.Windows.Forms.DataGridView();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.darkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).BeginInit();
            this.SuspendLayout();
            // 
            // darkPanel
            // 
            this.darkPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.darkPanel.BackColor = System.Drawing.Color.Transparent;
            this.darkPanel.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.darkPanel.Controls.Add(this.TitleLabel);
            this.darkPanel.Controls.Add(this.StatisticLabel);
            this.darkPanel.Location = new System.Drawing.Point(50, 12);
            this.darkPanel.Name = "darkPanel";
            this.darkPanel.Size = new System.Drawing.Size(1063, 129);
            this.darkPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(113, 38);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1063, 61);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Тут Ви можете побачити Вашу статистику";
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Location = new System.Drawing.Point(149, 38);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(0, 17);
            this.StatisticLabel.TabIndex = 1;
            // 
            // StatisticTable
            // 
            this.StatisticTable.AllowUserToAddRows = false;
            this.StatisticTable.AllowUserToDeleteRows = false;
            this.StatisticTable.AllowUserToResizeColumns = false;
            this.StatisticTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.StatisticTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StatisticTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatisticTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatisticTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StatisticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticTable.Location = new System.Drawing.Point(211, 147);
            this.StatisticTable.Name = "StatisticTable";
            this.StatisticTable.ReadOnly = true;
            this.StatisticTable.RowTemplate.Height = 24;
            this.StatisticTable.Size = new System.Drawing.Size(762, 416);
            this.StatisticTable.TabIndex = 1;
            this.StatisticTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatisticTable_CellContentClick);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.Image = global::GoodVision.Properties.Resources._14;
            this.BackToMenuButton.ImageHover = global::GoodVision.Properties.Resources._14Hover;
            this.BackToMenuButton.ImageNormal = global::GoodVision.Properties.Resources._14;
            this.BackToMenuButton.Location = new System.Drawing.Point(12, 432);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(192, 152);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.UseVisualStyleBackColor = false;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 596);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.StatisticTable);
            this.Controls.Add(this.darkPanel);
            this.DoubleBuffered = true;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.darkPanel.ResumeLayout(false);
            this.darkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel darkPanel;
        private System.Windows.Forms.DataGridView StatisticTable;
        private System.Windows.Forms.Label StatisticLabel;
       // private rbutton.CustRoundButton BackToMainButton;
        private System.Windows.Forms.Label TitleLabel;
        private rbutton.CustRoundButton BackToMenuButton;
    }

}