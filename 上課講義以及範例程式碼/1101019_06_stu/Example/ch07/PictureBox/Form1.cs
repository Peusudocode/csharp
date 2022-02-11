using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int current;              // 目前顯示的圖像檔順序
        int rate;　　　　　　　　 // 圖像方塊的縮放比例　　
        int wide, high, pX, pY;   // 存放圖片方塊原始的大小、座標

        // 自定函式用來設定圖片方塊經切換圖像或縮放調整後的大小與座標
        private void FigShow()
        {
            lblCurrent.Text = "第 " + current + " 張圖像";
            // pic.Image = Image.FromFile(@"c:\pic\pic" + current + ".jpg");
            //pic.Image = Image.FromFile(@"pic\pic" + current + ".jpg");
            pic.Image = Image.FromFile(@"..\..\pic\pic" + current + ".jpg");
            if (current == 1) btnPre.Enabled = false;
            else btnPre.Enabled = true;
            if (current == 6) btnNext.Enabled = false;
            else btnNext.Enabled = true;

            lblRate.Text = "圖像顯示比例： " + rate + " %";
            int W = wide * rate / 100;      // 圖片方塊縮放後寬度
            int H = high * rate / 100;      // 圖片方塊縮放後高度
            pic.Size = new Size(W, H);      // 設定圖片方塊的大小
            // 設定圖片方塊顯示的位置，中心位置恆不變
            pic.Location = new Point(pX + (wide - W) / 2, pY + (high - H) / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            wide = pic.Width;
            high = pic.Height;
            pX = pic.Left;
            pY = pic.Top;
            current = 1;                  // 設定顯示的圖像檔順序為 1
            rate = 80;                    // 設定顯示比例為80%
            FigShow();
        }
        
        private void btnPre_Click(object sender, EventArgs e)
        {
            current--;
            FigShow();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            FigShow();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            if (rate < 100)
            {
                rate += 10;
                FigShow();
            }
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            if (rate > 10)
            {
                rate -= 10;
                FigShow();
            }
        }
    }
}
