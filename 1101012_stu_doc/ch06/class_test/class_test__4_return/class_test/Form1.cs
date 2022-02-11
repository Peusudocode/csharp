using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Needs a variable to access object
            Student s = new Student(); //Generate object
            s.Name = "testname1";
            s.Grade = 3;
            // MessageBox.Show(s.Say());
            // s.Upgrade();
            //  MessageBox.Show(s.Say());
            Student s2 = new Student();
            s2.Name = "testname2";
            s2.Grade = 2;

            MessageBox.Show(s.Talk(s2));

        }
    }
}
