using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GoodVision
{   // класс и его члены объявлены как public
   
    [Serializable]
    public class UserClass
    {
        [XmlIgnore]
        public string Nickname;//имя
        //[XmlIgnore]
        public FileStream FilePath;
        
        public DateTime last_check_date;//дата проверки(последней)
        
        public DateTime check_date;//произвольная дата когда пользователь чекал зрение нинаю пока куда его припхнуть, но явно понадобится для того чтобы статку чекать
        
        public double left_eye_vision;//зрание для левого глаза
        
        public double right_eye_vision;//для правого

		public UserClass() { }
        public UserClass(UserClass User)//конструктор
        {
            this.Nickname = User.Nickname;
            this.left_eye_vision = User.left_eye_vision;
            this.right_eye_vision = User.right_eye_vision;
            this.last_check_date = User.last_check_date;
			
	}
        public string Nick {
			get {
				return this.Nickname;
			}
			set {
				this.Nickname = value;

			}
		}
		public FileStream File
		{
			get
			{
				return this.FilePath;
			}
			set
			{
				this.FilePath = value;
			}
		}//ввести или получить имя
		public double left {
			get
			{
				return this.left_eye_vision;
			}
			set
			{
				this.left_eye_vision = value;
			}
		}
		public double right
        {
            get
            {
                return this.right_eye_vision;
            }
            set
            {
                this.right_eye_vision = value;
            }
        }
        
        public DateTime last_date {
			get
			{
				return this.last_check_date;
			}
			set
			{
				this.last_check_date = value;
			}
		}
		public double get_last_left_eye_vision(UserClass User)//получить зрение для левого глаза для последней проверки
        {
            return User.left_eye_vision;
        }
        public double get_last_right_eye_vision(UserClass User)//получить зрение для правого последней проверки
        {
            return User.right_eye_vision;
        }
        public Tuple<double, double> get_last_vision(UserClass User)//получить зрение для обоих глаз последней проверки
        {
            var vision = new Tuple<double, double>(User.left_eye_vision, User.right_eye_vision);
            return vision;
        }
         
        public UserClass Get_Stats(ref UserClass User)
        {
            //показать статистику
            XmlSerializer xml = new XmlSerializer(typeof(UserClass));
            string filePath = User.Nick + ".xml";
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                UserClass newPerson = (UserClass)xml.Deserialize(fs);
                //здесь можем манипулировать всем!
                //Console.WriteLine("Объект десериализован");
                return newPerson;
            }
        }

        ~UserClass() { }
        
    }
}
