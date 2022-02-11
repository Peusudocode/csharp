using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] picFire = new PictureBox[10];//宣告一個圖片方塊陣列成員
        private void Form1_Load(object sender, EventArgs e)
        {
            picTank.Image = Image.FromFile("tank.gif");//載入坦克圖檔
            for(int i = 0; i < 10; i++)  //由0~9逐一建立物件
            {
                picFire[i] = new PictureBox();  //建立物件
                picFire[i].Size = new Size(3, 6);//設砲彈大小
                picFire[i].BackColor = Color.Red;//設砲彈顏色
                picFire[i].Visible = false;      //設砲彈不可見
                this.Controls.Add(picFire[i]);  //將砲彈加入表單
            }
            tmrShoot.Start();   //開始計時器
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)          // 根據e.KeyCode分別執行
            {
                case Keys.Left:          // 若按向左鍵
                    picTank.Left -= 5;       // 左移5點
                    break;
                case Keys.Right:         // 若按向右鍵
                    picTank.Left += 5;      // 右移5點
                    break;
                case Keys.Space:         // 若按空白鍵
                    for (int i = 0; i < 10; i++)  //由0~9逐一檢查
                    {
                        if (picFire[i].Visible == false)  //若砲彈不可見
                        {
                            picFire[i].Visible = true;//砲彈設為可見
                            //設砲彈的位置為目前坦克位置的中央上方
                            picFire[i].Location = new Point(picTank.Left + 19, picTank.Top + 6);
                            break;  //離開for迴圈
                        }
                    }
                    break;
            }
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)  //由0~9逐一移動砲彈
            {
                if (picFire[i].Visible == true)  //若砲彈為可見
                {
                  picFire[i].Top -= 8;     //砲彈上移8點
                    if (picFire[i].Top <= -6)   //若砲彈Y座標<=-6
                        picFire[i].Visible = false;//設砲彈不可見
                }
            }
        }
    }
}
