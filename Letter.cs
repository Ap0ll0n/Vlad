using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace GoodVision
{
   class Letter : Object
    {
       public enum Letters : int//список букв в таблице Сивцева
        {
            Ш = 1,
            Б,
            М,
            Н,
            К,
            Ы,
            И
        };
        private Letters Letter_to_show;//Буква которая будет для каждого объекта класса 
        public int Get_Random()//случайная генерация числа 1-7
        {
            Random rnd = new Random();
            int Random_Letter = rnd.Next(1,8);
            return Random_Letter;
        }
        public Letter()//конструктор в котором буква для каждого объекта будет по умолчанию выбрана случайно
        {
			this.Set_Letter();
        }
        public void Set_Letter()//метод для установки значения буквы 
        {
			this.Letter_to_show = (Letters)Get_Random();
			switch (Letter_to_show)
			{
				case Letters.Ш:
					{
						this.ShowImage = Properties.Resources.Ш;
                        this.Name = "Ш";
						break;
					}
				case Letters.Б:
					{
						this.ShowImage = Properties.Resources.Б;
                        this.Name = "Б";

                        break;
					}
				case Letters.М:
					{
						this.ShowImage = Properties.Resources.М;
                        this.Name = "М";
                        break;
					}
				case Letters.Н:
					{
						this.ShowImage = Properties.Resources.Н;
                        this.Name = "Н";
                        break;
					}
				case Letters.К:
					{
						this.ShowImage = Properties.Resources.К;
                        this.Name = "К";
                        break;
					}
				case Letters.Ы:
					{
						this.ShowImage = Properties.Resources.Ы;
                        this.Name = "Ы";
                        break;
					}
				case Letters.И:
					{
						this.ShowImage = Properties.Resources.И;
                        this.Name = "И";
                        break;
					}
			}
          //  this.ShowImage = Image.FromFile(this.FileName);
        }
		public string Get_Letter()//метод для установки значения буквы вручную
		{
			string name = this.Name;
			return name;
		}
		
        ~Letter() { }
    }
}
