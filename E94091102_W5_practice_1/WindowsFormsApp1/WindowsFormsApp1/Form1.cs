using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 替換式密碼 : Form
    {
        public 替換式密碼()
        {
            InitializeComponent();
        }
        Password password1 = new Password();
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "替換表";
            label3.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            textBox1.Visible = false;
            label4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = password1.Generate();
            password1.Generate_Alphabet = textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "替換表")
            {   label2.Text = password1.Check(textBox2.Text);
                if (label2.Text == "替換表不合法，請重新輸入")
                {
                textBox2.Text = "";
                }
                else
                {
                    password1.Generate_Alphabet = textBox2.Text;
                }
            }
            else if (label1.Text == "加密")
            {
                MessageBox.Show(password1.Generate_Alphabet);
                textBox2.Text = password1.Encrypt(textBox1.Text, password1.Generate_Alphabet);
            }
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "替換表";
            label3.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            textBox1.Visible = false;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "加密";
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            label3.Text = "輸入字串";
            label4.Text = "加密結果";
            label2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "解密";
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            label3.Text = "輸入密文";
            label4.Text = "解密結果";
            label2.Visible = false;

        }
    }
}
