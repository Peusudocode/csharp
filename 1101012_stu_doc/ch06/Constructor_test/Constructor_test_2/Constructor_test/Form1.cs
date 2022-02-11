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
            Student s1 = new Student();  // Question 1. Write a four-line code to create an object, 2. Repeat setting the same value

            s1.Name = "testname1";
            s1.StudentID = 10602001;

            Student s2 = new Student();
            s1.Name = "testname2";
            s1.StudentID = 10602002;

            MessageBox.Show(s2.Say());
        }
    }
}
