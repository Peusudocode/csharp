using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_private
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
            //   if (user.HP >=10)
            //  user.HP -= 10; // If you want to use it in many places, you must repeat the same code many times

            user.hurt(30);
            user.hurt(10);
        //    user.hurt(10);

            MessageBox.Show("-->" + user.getHP());

        }
    }
}
