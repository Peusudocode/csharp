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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int current;              // 目前顯示的圖像檔順序
        int rate;　　　　　　　　 // 圖像方塊的縮放比例　　
        int wide, high, pX, pY;// 存放圖片方塊原始的大小、座標
        Class1 text;
        private void FigShow()
        {
            pictureBox1.Image = Image.FromFile(@"..\..\Practice2_picture\pic_04.png");
            int W = wide * rate / 100;      // 圖片方塊縮放後寬度
            int H = high * rate / 100;      // 圖片方塊縮放後高度
            pictureBox1.Size = new Size(W, H);      // 設定圖片方塊的大小
            // 設定圖片方塊顯示的位置，中心位置恆不變
            pictureBox1.Location = new Point(pX + (wide - W) / 2, pY + (high - H) / 2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            wide = pictureBox1.Width;
            high = pictureBox1.Height;
            pX = pictureBox1.Left;
            pY = pictureBox1.Top;
            current = 1;                  // 設定顯示的圖像檔順序為 1
            rate = 80;                    // 設定顯示比例為80%
            FigShow();
            textBox1.Text = "12";
            text.Size = int.Parse(textBox1.Text);
            textBox2.Text = "你好";
            label3.Text = textBox2.Text;
            label1.TextAlign = ContentAlignment.TopLeft;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (current == 1)
            {
                current = 5;
            }
            else
            {
                current--;
            }
            FigShow();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (current == 5)
            {
                current = 1;
            }
            else
            {
                current++;
            }
            FigShow();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 32)
            {
                textBox1.Text = "12";
            }
            text.Size = int.Parse(textBox1.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            text.Y_Location = 12;
            text.Alignment = ContentAlignment.TopLeft;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            text.Y_Location = 12;
            text.Alignment = ContentAlignment.TopCenter;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            text.Y_Location = 12;
            text.Alignment = ContentAlignment.TopRight;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            text.Y_Location = 450;
            text.Alignment = ContentAlignment.BottomLeft;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            text.Y_Location = 450;
            text.Alignment = ContentAlignment.BottomCenter;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            text.Y_Location = 450;
            text.Alignment = ContentAlignment.BottomRight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
