using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User("nckuuser", "111");

             //   user.HP = -10; ///Call set and pass the value to it , value = -10 
             user.HP = 10;
         //   MessageBox.Show("HP-->" + user.HP);

            MessageBox.Show("Money-->" + user.Money);
        }
    }
}
