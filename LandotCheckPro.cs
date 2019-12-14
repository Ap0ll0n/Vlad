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
    public partial class LandotCheckPro : Form
    {
        public LandotCheckPro()
        {
            InitializeComponent();
        }
        int i = 5, temp;
		bool eye = true;
		Landolt_Circle Circle = new Landolt_Circle();
		int Direction;
		int rightAnswer = 0;
		int tests = 0;
		int left = 1;
		int right = 12;
        //Users ob = new Users();
		UserClass User = new UserClass();
		GoodVisionClass MyVision = new GoodVisionClass();

		private void GoLandotButton_Click(object sender, EventArgs e) // Запуск тестирования Сюда первую картинку надо
        {
            LandotCirclePictureBox.Size = new System.Drawing.Size(15, 15);
            LandotTimer.Value = 0;

            Circle.ObjectRow = 6;
			right = 12;
			left = 1;
			tests = 0;

			EyeTestPanel.Visible = false;             // предупреждение про проверку правого глаза уходит
            System.Threading.Thread.Sleep(100);
            LTimer.Enabled = true;

            Point point = new Point((124 - LandotCirclePictureBox.Width / 2), 108 - (LandotCirclePictureBox.Height) / 2);
            LandotCirclePictureBox.Location = point;

            LandotCirclePictureBox.Image = Circle.ShowImage;

            MessagePanel.Visible = false;
            temp = 6;
            tests = 0;
            left = 1;
            right = 12;

        }


        private void BackToVisionCheckButton_Click(object sender, EventArgs e)// возврат на предыдущую страницу
        {
            MainMenu Vch = new MainMenu();
            Vch.Show();
            this.Hide();
        }

        private void LTimer_Tick_1(object sender, EventArgs e)
        {
                      
            temp--;
            LandotTimer.Text = Convert.ToString(temp);    
            LandotTimer.PerformStep();
            if (temp != 0)
            { LTimer.Enabled = true; }

            else
            {
                LTimer.Enabled = false;
                MessagePanel.Visible = true;
            }
            }

    
        // Выбор ответа

        private void UpLandotButton_Click(object sender, EventArgs e) //здесь можно добавить смену картики и считывание ответа
        {
			Direction = 1;
			DirectionClick();
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void LeftLandotButton_Click(object sender, EventArgs e)
        {
			Direction = 3;
			DirectionClick();
			LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }


        private void DownLandotButton_Click(object sender, EventArgs e)
        {
			Direction = 2;
			DirectionClick();
			LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void RightLandotButton_Click(object sender, EventArgs e)
        {
			Direction = 4;
			DirectionClick();
			LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

		private void LandotCheckPro_Load(object sender, EventArgs e)
		{
			FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
			if (session != null)
			{
				StreamReader reader = new StreamReader(session);
				User.Nick = reader.ReadToEnd();
				session.Close();
                LandotCirclePictureBox.Image = Circle.ShowImage;
            }
			session.Close();

		}

		private void LandotCheckPro_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void DirectionClick()
		{
            MessagePanel.Visible = false;
            if (Direction == Circle.Directions)
			{
				rightAnswer++;
                tests++;
			}
            if (Direction != Circle.Directions)
            {
                tests++;
            }


			if (tests < 3)
			{
				Circle.Set_Circle();
				LandotCirclePictureBox.Image = Circle.ShowImage;
                Point point = new Point((124 - LandotCirclePictureBox.Width / 2), 108 - (LandotCirclePictureBox.Height) / 2);

                LandotCirclePictureBox.Location = point;
			}
			else if (rightAnswer >= 2)
			{
				rightAnswer = 0;
				left = Circle.ObjectRow;
				Circle.ObjectRow = (left + right) / 2;
				if (left == 11) Circle.ObjectRow = 12;
				tests = 0;
				Circle.Set_Circle();
				Circle.CalcSize();
				if (left <= 9)
				{
					LandotCirclePictureBox.Size = new System.Drawing.Size((int)Circle.Get_size().Item1, (int)Circle.Get_size().Item2);
                    Point point = new Point((124 - LandotCirclePictureBox.Width / 2), 108 - (LandotCirclePictureBox.Height) / 2);
                    LandotCirclePictureBox.Location = point;
					this.LandotCirclePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					this.LandotCirclePictureBox.BorderStyle = BorderStyle.None;
					LandotCirclePictureBox.Image = Circle.ShowImage;
				}
			}
			else if (rightAnswer < 2)
			{
				right = Circle.ObjectRow;
				if (left < right)
				{
					Circle.ObjectRow = (left + right) / 2;
					Circle.CalcSize();
					if (left <= 9)
					{
						LandotCirclePictureBox.Size = new System.Drawing.Size((int)Circle.Get_size().Item1, (int)Circle.Get_size().Item2);
                        Point point = new Point((124 - LandotCirclePictureBox.Width / 2), 108 - (LandotCirclePictureBox.Height) / 2);
                        LandotCirclePictureBox.Location = point;
						this.LandotCirclePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
						this.LandotCirclePictureBox.BorderStyle = BorderStyle.None;
						LandotCirclePictureBox.Image = Circle.ShowImage;
						tests = 0;
					}
				}
			}
			if(left >= right || right == Circle.ObjectRow || left == Circle.ObjectRow)
			{
				if (eye)//какой глаз сейчас проверяем
				{
					User.left = Circle.Get_result(Circle.ObjectRow - 1);
					eye = false;
                    EyeTestPanel.Visible = true;
                    EyeTextLabel.Text = "Тестуємо праве око.\n Будь ласка, закрийте ліве\n та нажміть ''старт''";
                }
				else
				{
					User.right = Circle.Get_result(Circle.ObjectRow - 1);

					User.check_date = DateTime.Now;
					MyVision.Add_to_file(ref User);
					AfterTestingForm form = new AfterTestingForm(User);

					form.Show();
					this.Hide();
				}
			}

			
		}

    }
}
