using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(10602001, "testname1");  

            Student s2 = new Student(10602002, "testname2"); ;
            MessageBox.Show(s1.Say());
            MessageBox.Show(s2.Say());
        }
    }
}
