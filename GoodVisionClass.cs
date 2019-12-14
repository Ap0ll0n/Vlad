using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GoodVision
{
	class GoodVisionClass : GoodVisionInterface
	{
		bool regMess;
		public GoodVisionClass()
		{
		}

		public void Add_to_file(ref UserClass User)
		{
			/*
            //добавление в файл пользователя данных
            //XML Serizalisation
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(UserClass));
            string filePath = User.Nick + ".xml";
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
                fs.Close();
                
                //Console.WriteLine("Объект сериализован");
            }
            */

			string filePath = User.Nick + ".xml";
			//XDocument doc = XDocument.Load(filePath);
			//XElement root = new XElement("Snippet");
			//root.Add(new XAttribute("name", "name goes here"));
			//root.Add(new XElement("SnippetCode", "SnippetCode"));
			//doc.Element("Snippets").Add(root);
			//doc.Save(filePath);
			try
			{
				if (!File.Exists(filePath))
				{
					Create_account(ref User);
				}
				else
				{
					XDocument xDocument = XDocument.Load(filePath);
					XElement root2 = xDocument.Element("UserData");
					IEnumerable<XElement> rows = root2.Descendants(User.Nick);
					XElement firstRow = rows.First();
					XElement userEl = new XElement(User.Nick);
					XElement dateEl = new XElement("Date", User.check_date.ToString());
					XElement leftEl = new XElement("Left", User.left.ToString());
					XElement rightEl = new XElement("Right", User.right.ToString());

					userEl.Add(dateEl);
					userEl.Add(leftEl);
					userEl.Add(rightEl);
					firstRow.AddBeforeSelf(userEl);
					xDocument.Save(filePath);
				}
			}
			catch (FileNotFoundException ex)
			{
				MessageBox.Show("Error!");
			}

		}
		/*
        void SerializeXML(ref Users userList)
        {//List<UserClass> userList = new List<UserClass>();
            //добавление в файл пользователя данных
            //XML Serizalisation
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<UserClass>));
            string filePath = User.Nick + ".xml";
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, userList);
                //fs.Close();
                //Console.WriteLine("Объект сериализован");
            }

        }
        */
		public static bool mode;


		public void Clear_account(ref UserClass User)
		{
			try
			{
				File.Delete(User.Nick + ".xml");
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("");
			}

		}


		public void Test_vision_with_circles(ref UserClass User)
		{
			throw new NotImplementedException();
		}

		public void Test_vision_with_letters(ref UserClass User)
		{

		}

		public void Create_account(ref UserClass User)
		{
			string filePath = User.Nick + ".xml";
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.NewLineOnAttributes = true;
			using (XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlWriterSettings))
			{
				xmlWriter.WriteStartDocument();
				xmlWriter.WriteStartElement("UserData");

				xmlWriter.WriteStartElement(User.Nick);
				xmlWriter.WriteElementString("Date", null);
				xmlWriter.WriteElementString("Left", null);
				xmlWriter.WriteElementString("Right", null);
				xmlWriter.WriteEndElement();

				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndDocument();
				xmlWriter.Flush();
				xmlWriter.Close();
			}


		}
		public bool ExchangeRegMessage
		{
			get { return regMess; }
			set { regMess = value; }
		}


	}
}
