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
            string result = "";
            if (user.comparePassword("111"))
                result = "ok!";
            else
                result = "err!";
          //  MessageBox.Show(result);
            MessageBox.Show(user.getUsername()); //read only //Can't modify, but can know the content
        }
    }
}
