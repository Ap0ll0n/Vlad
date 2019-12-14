using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoodVision
{
	public partial class AfterTestingForm : Form
	{
		public AfterTestingForm(UserClass u)
		{
			InitializeComponent();
			User = u;
		}
		UserClass User;

		private void BackToMenuButton_Click(object sender, EventArgs e) // возврат в меню
		{
			MainMenu mMen = new MainMenu();
			mMen.Show();
			this.Hide();
		}


		private void VisionCheckButton_Click(object sender, EventArgs e) // переход на форма проверка зрения
		{
			VisionCheck Vch = new VisionCheck();
			Vch.Show();
			this.Hide();
		}

		private void StatistButton_Click(object sender, EventArgs e) // переход на форму статистики
		{
			StatisticForm stat = new StatisticForm(true);
			stat.Show();
			this.Hide();
		}

		private void AfterTestingForm_Load(object sender, EventArgs e)
		{
			FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
			if (session != null)
			{
				StreamReader reader = new StreamReader(session);
				User.Nick = reader.ReadToEnd();
				session.Close();
			}
			this.LeftEyeRes.Text = User.left.ToString();
			this.RightEyeRes.Text = User.right.ToString();

		}

		private void AfterTestingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
