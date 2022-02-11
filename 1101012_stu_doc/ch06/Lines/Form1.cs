using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strAry1 = new string[] { "讀資工，肝一輩子。", "不讀資工，還是肝一輩子！" };
            textBox1.Lines = strAry1;

            label1.Text = textBox1.Lines[0];
            label2.Text = textBox1.Lines[1];

            string[] strAry2 = new string[2];
            for (int n = 0; n <= strAry2.Length - 1; n++)
                strAry2[n] = textBox1.Lines[n];

            label3.Text = "";
            for (int k = 0; k <= strAry2.Length - 1; k++)
                label3.Text += (strAry2[k] + '\n');
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
