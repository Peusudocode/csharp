using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] pic = new PictureBox[9];   //宣告圖片方塊物件陣列
        int hit = 0;    //紀錄擊中次數
        int miss = 0;   //紀錄失誤次數
        int mouse = 0;  //紀錄地鼠的位置
        double sec;     //紀錄剩餘秒數

        private void Form1_Load(object sender, EventArgs e)
        {
            pic[0] = pic1; pic[1] = pic2; pic[2] = pic3;//指定圖片方塊物件陣列元素
            pic[3] = pic4; pic[4] = pic5; pic[5] = pic6;
            pic[6] = pic7; pic[7] = pic8; pic[8] = pic9;
            pic2.Click += pic1_Click; pic3.Click += pic1_Click;//訂閱共享事件
            pic4.Click += pic1_Click; pic5.Click += pic1_Click;
            pic6.Click += pic1_Click; pic7.Click += pic1_Click;
            pic8.Click += pic1_Click; pic9.Click += pic1_Click;
            for (int i = 0; i < 9; i++)
            {
                pic[i].Image = imgPic.Images[0];//載入第一個圖
                pic[i].Enabled = false; //不能使用
                pic[i].Tag = i; //設Tag屬性值為i
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hit = 0; miss = 0;  //預設擊中和失誤次數都為0
            lblHit.Text = "擊中： " + hit.ToString() + " 次";
            lblMiss.Text = "失誤： " + miss.ToString() + " 次";
            for (int i = 0; i < 9; i++)
            {
                pic[i].Image = imgPic.Images[0];//載入第一個圖
                pic[i].Enabled = true;//可以使用
            }
            btnStart.Enabled = false;//開始鈕不能使用
            sec = 10;   //設剩餘秒數為30
            tmrT.Enabled = true;    //計時器啟動
            Random rnd = new Random();  //宣告亂數物件rnd
            mouse = rnd.Next(0, 9);//產生0~8亂數為地鼠位置
            pic[mouse].Image = imgPic.Images[1];//該圖片方塊載入第二個圖
        }

        private void tmrT_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (sec -= 0.1).ToString("#.0") + " 秒"; //秒數-0.1並顯示
            if (sec <= 0)   //若剩餘秒數歸零
            {
                tmrT.Enabled = false;   //計時器關閉
                for (int i = 0; i < 9; i++)
                {
                    pic[i].Enabled = false; //圖片方塊不能使用
                }
                btnStart.Enabled = true;//開始鈕可以使用
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            PictureBox picClick = (PictureBox)sender;   //將sender轉型為圖片物件picClick
            int Tag = (int)picClick.Tag;
            int temp_mouse1 = mouse;
            if ((int)picClick.Tag == mouse)   //若picClick.Tag=地鼠位置
            {
                hit += 1;   //擊中次數加1
                lblHit.Text = "擊中： " + hit.ToString() + " 次";
                picClick.Image = imgPic.Images[0];//載入第一個圖
                Random rnd = new Random();
                mouse = rnd.Next(0, 9);//產生0~8亂數為地鼠位置
                pic[mouse].Image = imgPic.Images[1];//該圖片方塊載入第二個圖
            }
            else
            {
                miss += 1;  //失誤次數加1
                lblMiss.Text = "失誤： " + miss.ToString() + " 次";
            }
        }
    }
}
