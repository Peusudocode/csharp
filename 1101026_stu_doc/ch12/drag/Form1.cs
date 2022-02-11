using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drag = false;   // 記錄是否可拖曳，預設為不可
        int sX, sY;         // 記錄滑鼠按下時的座標値

        private void Form1_Load(object sender, EventArgs e)
        {
            picBox.Image = imgBox.Images[0];
        }

        private void picBox_MouseEnter(object sender, EventArgs e)
        {
            picBox.Image = imgBox.Images[1];
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)    // 若按左鍵時
            {
                drag = true;                 // 設為可拖曳
                sX = e.X; sY = e.Y;          // 記錄滑鼠指標的座標値
            }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)   //若drag=true
            {
                picBox.Left += (e.X - sX);   // 設圖片X位置
                picBox.Top += (e.Y - sY);    // 設圖片Y位置
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; ;    //設為不可拖曳
        }

        private void picBox_MouseLeave(object sender, EventArgs e)
        {
            picBox.Image = imgBox.Images[0];
        }
    }
}
