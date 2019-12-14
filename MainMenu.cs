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
    public partial class MainMenu : Form
    {
        
		public MainMenu()
        {
            InitializeComponent();
           
        }
		UserClass User=new UserClass() ;
		GoodVisionClass MyVision;
        HellpMessage help = new HellpMessage();

        private void StaticticButton_Click(object sender, EventArgs e)  // просмотр статистики
        {
            StatisticForm statForm = new StatisticForm();
            statForm.Show();
            this.Hide();

        }

        private void VisionCheckButton_Click(object sender, EventArgs e) // переход к форме тестирования
        {
            VisionCheck VChForm = new VisionCheck();
            VChForm.Show();
            this.Hide();
        }


        // вызываем помощь для главного меню
        private void HelpButton_Click(object sender, EventArgs e) 
        {
            help.Hide();
            help.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
            if (session != null)
            {
                StreamReader reader = new StreamReader(session);
                User.Nick = reader.ReadToEnd();
                session.Close();
            }
            //считать данные из файла данной сессии (имя)
            //открыть файл по имени пользователья с его данными

            HelloLab.Text = "Вітаємо, " + User.Nick;
        }

        

      

      

        private void eyePictureBox_MouseLeave(object sender, EventArgs e)
        {
            eyePictureBox.Image = Properties.Resources.eye1;
        }

        private void eyePictureBox_MouseEnter(object sender, EventArgs e)
        {

            eyePictureBox.Image = Properties.Resources.eye2;
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            
            RegForm reg1 = new RegForm();
            reg1.Show();
            this.Hide();
        }

		private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
