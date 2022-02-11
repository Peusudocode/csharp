using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fontSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFont.Text = "反毒";
            nudSize.Minimum = 8; nudSize.Maximum = 80;//設定最小最大值
            nudSize.Increment = 4;  //設定增減值為4
            nudSize.Value = 24;     //設定初值為24
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {   //設定新的字型樣式
         //   lblFont.Font = new Font("標楷體", (float)nudSize.Value);
            lblFont.Font = new Font("標楷體", (int)nudSize.Value);
        }
    }
}
