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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;  // 表單接收所有按鍵事件
            this.FormBorderStyle = FormBorderStyle.Fixed3D;  // 表單大小固定
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   //在表單的KeyDown事件中
            int s = 0;  //s紀錄移動點數
            if (e.Shift == true)
            {   //若e.Shift 屬性值為 true
                this.Text = "按Shit鍵";   //設表單標題
                s = 10; //移動點數為10點
            }
            else
            {
                this.Text = "未按Shit鍵";
                s = 1;    //移動點數為1點
            }
            switch (e.KeyCode)        // 根據e.KeyCode分別執行
            {
                case Keys.Left:        // 若按向左鍵
                    picP.Left -= s;  // 左移s點
                    break;
                case Keys.Right:       // 若按向右鍵
                    picP.Left += s;  // 右移s點
                    break;
                case Keys.Down:       // 若按向下鍵
                    picP.Top += s;  // 下移s點
                    break;
                case Keys.Up:         // 若按向上鍵
                    picP.Top -= s;  // 上移s點
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {   //在表單的KeyUp事件中
            this.Text = "復原";
            picP.Location = new Point(116, 116);   // 回到起始位置
        }

        private void picP_Click(object sender, EventArgs e)
        {

        }
    }
}
