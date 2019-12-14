using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GoodVision
{

    abstract public class Object
    {
        protected Tuple<double, double> size;
        protected string Name;
        public Image ShowImage;
		protected int Row;
        //   protected double[] Coefficients = new double[12];
        protected double[] Coefficients = new double[12];
        public Object()
        {
           this.size = new Tuple<double, double>(2.33333333, 2.33333333);//размер изображения в милиметрах для 6(базовой строки)
           for(int i = 1; i < 11; i++)
			{
				Coefficients[i - 1] = i * 0.1;
			}
			Coefficients[10] = 1.5;
			Coefficients[11] = 2.0;
        }
        public Object(Object Obj)
        {
           // this.FileName = Obj.FileName;
           // ShowImage = Image.FromFile(this.FileName);
            this.size = Obj.size;
        }
		public double Get_result(int i)
		{
			return Coefficients[i];
		}
        virtual public Tuple<double, double> Get_size()
        {

            return size;
        }

        virtual public void Set_size(Tuple<double, double> Size)
        {
            this.size = Size;
            }

            public void CalcSize()
            {
                double Size = (7 / Coefficients[Row - 1] / 4) * 3.85;
                this.size = new Tuple<double, double>(Size, Size);
            }

         public int ObjectRow
		{
			get
			{
				return Row;
			}
			set
			{
				Row = value;
			}
		}
        ~Object(){}
    };
}


