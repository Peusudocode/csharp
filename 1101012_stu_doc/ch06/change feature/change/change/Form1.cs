using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font f;

            label1.BackColor = System.Drawing.Color.LightPink;
            label1.ForeColor = System.Drawing.Color.Yellow;
            
            f = new Font("標楷體", 30, FontStyle.Bold);
            label2.Font = f;

            button3.TextAlign = ContentAlignment.TopLeft;

            textBox1.TextAlign = HorizontalAlignment.Right;

            pictureBox1.BackColor = System.Drawing.Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font f;

            label1.BackColor = System.Drawing.Color.BlueViolet;
            label1.ForeColor = System.Drawing.Color.YellowGreen;

            f = new Font("細明體", 30, FontStyle.Strikeout);
            label2.Font = f;

            button3.TextAlign = ContentAlignment.BottomRight;

            textBox1.TextAlign = HorizontalAlignment.Left;

            pictureBox1.BackColor = System.Drawing.Color.Silver;
        }
    }
}
