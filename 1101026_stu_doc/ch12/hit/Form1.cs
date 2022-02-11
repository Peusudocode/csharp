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

        Button[] btn = new Button[9];   //宣告按鈕物件陣列
        int hit = 0;    //紀錄擊中次數
        int miss = 0;   //紀錄失誤次數
        double sec;     //紀錄剩餘秒數

        private void Form1_Load(object sender, EventArgs e)
        {
            btn[0] = btn1; btn[1] = btn2; btn[2] = btn3;//指定按鈕物件陣列元素
            btn[3] = btn4; btn[4] = btn5; btn[5] = btn6;
            btn[6] = btn7; btn[7] = btn8; btn[8] = btn9;
            btn2.Click += btn1_Click; btn3.Click += btn1_Click;//訂閱共享事件
            btn4.Click += btn1_Click; btn5.Click += btn1_Click;
            btn6.Click += btn1_Click; btn7.Click += btn1_Click;
            btn8.Click += btn1_Click; btn9.Click += btn1_Click;
            for (int i = 0; i < 9; i++)
            {
                btn[i].Text = "";   //空白字元
                btn[i].Enabled = false; //不能使用
            }
            sec = 10;   //設剩餘秒數為10
            lblTime.Text = sec.ToString("#.0");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hit = 0; miss = 0;  //預設擊中和失誤次數都為0
            lblHit.Text = "擊中： " + hit.ToString() + " 次";
            lblMiss.Text = "失誤： " + miss.ToString() + " 次";
            for (int i = 0; i < 9; i++)
            {
                btn[i].Text = "";
                btn[i].Enabled = true;//可以使用
            }
            btnStart.Enabled = false;//開始鈕不能使用
          //  sec = 10;   //設剩餘秒數為10
         //   lblTime.Text = sec.ToString("#.0");
            tmrT.Enabled = true;    //計時器啟動
            Random rnd = new Random();  //宣告亂數物件rnd
            btn[rnd.Next(0, 9)].Text = "X"; //產生0~8亂數，並設該按鈕的文字為X
        }

        private void tmrT_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (sec -= 0.1).ToString("#.0") + " 秒"; //秒數-0.1並顯示
            if (sec <= 0)   //若剩餘秒數歸零
            {
                tmrT.Enabled = false;   //計時器關閉
                for (int i = 0; i < 9; i++)
                {
                    btn[i].Enabled = false; //按鈕不能使用
                }
                btnStart.Enabled = true;//開始鈕可以使用
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;   //將sender轉型為按鈕物件btnClick
            if (btnClick.Text == "X")   //若按鈕文字為X
            {
                hit += 1;   //擊中次數加1
                lblHit.Text = "擊中： " + hit.ToString() + " 次";
                btnClick.Text = ""; //按鈕文字清空
                Random rnd = new Random();
                btn[rnd.Next(0, 9)].Text = "X"; //產生0~8亂數，並設該按鈕的文字為X
            }
            else
            {
                miss += 1;  //失誤次數加1
                lblMiss.Text = "失誤： " + miss.ToString() + " 次";
            }
        }
    }
}
