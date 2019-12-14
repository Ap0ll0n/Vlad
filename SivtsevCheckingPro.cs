using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace GoodVision
{
    public partial class SivtsevCheckingPro : Form
    {

		public SivtsevCheckingPro()
        {
            InitializeComponent();
          
        }

        int i = 6, temp;
		Letter NewLetter = new Letter();
        int rightAnswer = 0;
		int tests = 0;
		int left = 1;
		int right = 12;
		bool eye = true;
		UserClass User = new UserClass() ;
		GoodVisionClass MyVision= new GoodVisionClass();
        Point stLocation= new Point(385,246);
		

        private void AnswerSivtsevButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Visible = false;
            if (AnswerTextBox.Text == NewLetter.Get_Letter())
				{
					rightAnswer++;
                }
            AnswerTextBox.Text = string.Empty;
            //  i++; // Светлана , откуда здесь i?
            tests++;
			if (tests < 3)
			{
				NewLetter.Set_Letter();
				LetterPictureBox.Image = NewLetter.ShowImage;

                Point point = new Point((124 - LetterPictureBox.Width / 2), 108 - (LetterPictureBox.Height) / 2);


				LetterPictureBox.Location = point;
			}
			else if (rightAnswer >= 2)
			{
				rightAnswer = 0;
				left = NewLetter.ObjectRow;
				NewLetter.ObjectRow = (left + right) / 2;
				if (left == 11) NewLetter.ObjectRow = 12;
				tests = 0;
				NewLetter.Set_Letter();
				NewLetter.CalcSize();
				if (left <= 9)
				{
					
					LetterPictureBox.Size = new System.Drawing.Size((int)NewLetter.Get_size().Item1, (int)NewLetter.Get_size().Item2);
					this.LetterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					this.LetterPictureBox.BorderStyle = BorderStyle.None;
				  Point point = new Point((124 - LetterPictureBox.Width / 2), 108 - (LetterPictureBox.Height) / 2);
					LetterPictureBox.Location = point;
					LetterPictureBox.Image = NewLetter.ShowImage;
				}

			}

			else
			{

				right = NewLetter.ObjectRow;
				if (left < right)
				{
					NewLetter.ObjectRow = (left + right) / 2;
					NewLetter.CalcSize();



                    if (left <= 9)
                    {
                        LetterPictureBox.Size = new System.Drawing.Size((int)NewLetter.Get_size().Item1, (int)NewLetter.Get_size().Item2);
                        this.LetterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.LetterPictureBox.BorderStyle = BorderStyle.None;
                        Point point = new Point((124 - LetterPictureBox.Width / 2), 108 - (LetterPictureBox.Height) / 2);
                        LetterPictureBox.Location = point;
                        LetterPictureBox.Image = NewLetter.ShowImage;
                    }
                   

					tests = 0;

				}
			}
				if(left>=right || right == NewLetter.ObjectRow|| left== NewLetter.ObjectRow)
				{
                    if (eye)//какой глаз сейчас проверяем
                    {
                        User.left = NewLetter.Get_result(NewLetter.ObjectRow - 1);
                        eye = false;
                        timer1.Enabled = false;
                        EyeTestPanel.Visible = true;
                    AnswerSivtsevButton.Enabled = false;
                    EyeTextLabel.Text = "Тестуємо праве око.\n Будь ласка, закрийте ліве\n та нажміть ''старт''";
                        // вставить предупреждение про проверку левого глаза
                    }
                    else
                    {
                        User.right = NewLetter.Get_result(NewLetter.ObjectRow - 1);

					User.check_date = DateTime.Now;
					MyVision.Add_to_file(ref User);

                        AfterTestingForm form = new AfterTestingForm(User);
                        form.Show();
                        this.Hide();
                    }
				}
			
			


				SivtsevTimer.Value = 0;
				temp = 6; // temp=i;
				timer1.Enabled = true;
			
			
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            AnswerSivtsevButton.Enabled = true;
            SivtsevTimer.Value = 0;
            EyeTestPanel.Visible = false;// предупреждение про проверку правого глаза уходит

            NewLetter.Set_Letter();
            NewLetter.ObjectRow = 6; // задает начальное значение

            LetterPictureBox.Size = new System.Drawing.Size(15, 15);
            this.LetterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.LetterPictureBox.BorderStyle = BorderStyle.None;
            LetterPictureBox.Image = NewLetter.ShowImage;
            Point point = new Point((124 - LetterPictureBox.Width / 2), 108 - (LetterPictureBox.Height) / 2);


            LetterPictureBox.Location = point;
            MessagePanel.Visible = false;
            LetterPictureBox.Image = NewLetter.ShowImage;
            System.Threading.Thread.Sleep(100);

            timer1.Enabled = true;
            temp = 6;
            tests = 0;
            left = 1;
            right = 12;
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackFromSivtsevButton_Click(object sender, EventArgs e)
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e) 
        {
                    
                temp--;
                SivtsevTimer.Text = Convert.ToString(temp);
            SivtsevTimer.PerformStep();
            if (temp != 0)
                timer1.Enabled = true;

            else
            {
                timer1.Enabled = false;
                MessagePanel.Visible = true;
            }
            }

		private void SivtsevCheckingPro_Load(object sender, EventArgs e)
		{
			FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
			if (session != null)
			{
				StreamReader reader = new StreamReader(session);
				User.Nick = reader.ReadToEnd();
				session.Close();
			}
		}

        private void AnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar>1071 && e.KeyChar < 1104)|| (e.KeyChar> 1039 && e.KeyChar < 1071)||(e.KeyChar==1110)|| (e.KeyChar == 8))
            {
                if (AnswerTextBox.Text != string.Empty)
                {
                    AnswerTextBox.Text = string.Empty;
                }
                if (e.KeyChar == 1110)
                {
                    AnswerTextBox.Text = Convert.ToString('ы').ToUpper();
                }
                 else if (e.KeyChar == 8)
                {
                    AnswerTextBox.Text = string.Empty;
                }
                else AnswerTextBox.Text = Convert.ToString(e.KeyChar).ToUpper();
            }
        }

        private void SivtsevInstrTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SivtsevCheckingPro_KeyDown(object sender, KeyEventArgs e)
        {
            if (AnswerSivtsevButton.Enabled == true)
            {
                if (e.KeyValue == (char)13)
                {
                    AnswerSivtsevButton_Click(AnswerSivtsevButton, null);
                }
            }
        }

        private void SivtsevCheckingPro_Load_1(object sender, EventArgs e)
        {
            FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
            if (session != null)
            {
                StreamReader reader = new StreamReader(session);
                User.Nick = reader.ReadToEnd();
                session.Close();
            }
        }

		private void SivtsevCheckingPro_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void BackToVisionCheckButton_Click(object sender, EventArgs e)
        {
            MainMenu Vch = new MainMenu();
            Vch.Show();
            this.Hide();
        }



    
    }
}
