using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btnDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tstxtInput.Text = "Happy";      //預設功能表文字方塊內文字
            fontDialog1.ShowColor = true;   //設字型對話方塊中可以設定顏色
            fontDialog1.MinSize = 12;       //設字型對話方塊中可以設定字型最小值
            fontDialog1.MaxSize = 36;       //設字型對話方塊中可以設定字型最大值
            colorDialog1.FullOpen = true;   //設色彩對話方塊中自動開啟自訂色彩色盤
        }

        private void tstxtInput_TextChanged(object sender, EventArgs e)
        {
            btnDesign.Text = tstxtInput.Text;   //設btnDesign和tstxtInput的文字相同
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {   //當使用者在字型對話方塊中按確定鈕時
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   //設btnDesign和字型對話方塊設定的字型相同
                btnDesign.Font = fontDialog1.Font;
                //設btnDesign前景色和字型對話方塊設定的色彩相同
                btnDesign.ForeColor = fontDialog1.Color;
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {   //當使用者在色彩對話方塊中按確定鈕時
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {   //設btnDesign背景色和色彩對話方塊設定的色彩相同
                btnDesign.BackColor = colorDialog1.Color;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
