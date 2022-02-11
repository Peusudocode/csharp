using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClsTextBox()
        {
            txtN1.Text = "";   // 清除運算元1
            txtN2.Text = "";   // 清除運算元2
            lblAns.Text = "";  // 清除答案
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "+";
            ClsTextBox();
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "-";
            ClsTextBox();
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "*";
            ClsTextBox();
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "/";
            ClsTextBox();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double Res = 0, N1, N2;   // Res存放N1,N2兩數的運算結果
            try
            {
                N1 = double.Parse(txtN1.Text);
                N2 = double.Parse(txtN2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數值！", "錯誤訊息", MessageBoxButtons.OK);
                return;
            }

            if (lblOp.Text == "+") Res = N1 + N2;
            if (lblOp.Text == "-") Res = N1 - N2;
            if (lblOp.Text == "*") Res = N1 * N2;
            if (lblOp.Text == "/")
            {
                if (N2 == 0)
                {
                    MessageBox.Show("除數不能為零", "錯誤訊息", MessageBoxButtons.OK);
                    return;
                }
                Res = N1 / N2;
            }

            lblAns.Text = Res.ToString();    // 將運算結果顯示出來
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
