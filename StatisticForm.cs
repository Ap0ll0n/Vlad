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
	public partial class StatisticForm : Form
	{
		public StatisticForm()
		{
			InitializeComponent();


		}
		public StatisticForm(bool isAfterTesting)
		{
			InitializeComponent();

			AfterTesting = isAfterTesting;
		}
		UserClass User = new UserClass();
		private bool AfterTesting = false;

		public string StatistExchange // передаем имя пользователя в эту форму
		{
			get { return StatisticLabel.Text; }
			set { StatisticLabel.Text = value; }
		}



		private void BackToMenuButton_Click(object sender, EventArgs e)
		{
			MainMenu mMForm = new MainMenu();
			mMForm.Show();
			this.Hide();
		}

		private void StatisticTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void StatisticForm_Load(object sender, EventArgs e)
		{
			//Десериализатор Get_Stats здесь не используется (написал на всякий случай), вместо этого просто считываю файл 
			FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
			if (session != null)
			{
				StreamReader reader = new StreamReader(session);
				User.Nick = reader.ReadToEnd();
				session.Close();
			}
			this.TitleLabel.Text = "Ви можете побачити вашу статистику " ;
			DataSet ds = new DataSet();
			ds.ReadXml(User.Nick + ".xml");

			//if (AfterTesting == true)
			//{
			//	StatisticTable.Columns.Add("Data", "Дата");
			//	StatisticTable.Columns.Add("Left", "Гострота лівого ока");
			//	StatisticTable.Columns.Add("Right", "Гострота правого ока");

			//	DataGridView dg2 = new DataGridView();
			//	dg2.DataSource = ds.Tables[0];
			//	StatisticTable.Rows.Add(ds.Tables[0].Rows[0].ItemArray);

			//}
			//else
			//{
				StatisticTable.DataSource = ds.Tables[0];

				StatisticTable.Columns[0].HeaderText = "Дата";
				StatisticTable.Columns[1].HeaderText = "Гострота лівого ока";
				StatisticTable.Columns[2].HeaderText = "Гострота правого ока";

			//}
			//read from .txt
			string fileName = "session.txt"; //"условное" название, по идее .txt должен создаться после регистрации там же, где и User.xml
			string textLine = "";
			//string userName = "";
			System.IO.StreamReader objReader;
			objReader = new System.IO.StreamReader(fileName);
			textLine = objReader.ReadLine();


		}

		private void StatisticForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
