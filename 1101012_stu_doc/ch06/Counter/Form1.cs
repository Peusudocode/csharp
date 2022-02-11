using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            lblShow.Text = "輸入密碼後，按 [檢查] 鈕";
            txtPW.MaxLength = 8;
            txtPW.PasswordChar = '*';
            txtPW.Text = "";
            txtMoney.Text = "";
            txtMoney.Enabled = false;
            btnOk.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == "111")
            {
                btnOk.Enabled = true;
                txtMoney.Enabled = true;
                txtMoney.Focus();
                lblShow.Text = "輸入提領金額，按 [確定] 鈕";
            }
            else
            {
                lblShow.Text = "密碼錯誤！重新輸入";
                txtPW.Clear();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblShow.Text = "提領金額是 " + txtMoney.Text + " 元";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
