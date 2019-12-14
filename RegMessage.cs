using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodVision  
{
  public partial class RegMessage : Form
    {

        GoodVisionClass gv = new GoodVisionClass();
        RegForm regFor;
        // форма для подтверждения имени
        public int mode =0;
        public string userNick;
        UserClass User = new UserClass();
        public RegMessage(RegForm regF)
        {
            InitializeComponent();
            regFor=regF ;
          userNick = regFor.userNick;
            
        }


        private void YesButton_Click(object sender, EventArgs e)
        {
            regFor.Enter_account(userNick);
            regFor.Enabled = true;
            this.Close();
        }

 

        private void NoButton_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Користувач з таким логіном вже існує. Будьласка, змініть логін");
            regFor.Enabled = true;
            this.Hide();
        }
    }
}
