using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPW.MaxLength = 12;   //設最多輸入12個字元
            txtPW.PasswordChar = '*';   //設密碼輸入時顯示的字元
            txtMoney.Enabled = false;   //金額不能輸入
            lblMsg.Text = "請輸入晶片密碼(6~12位)後按下 Enter 鍵";
        }

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((byte)e.KeyChar < '0' || (byte)e.KeyChar > '9')   //若小於0或大於9
            {

                if ((byte)e.KeyChar == 13)   	//若是Enter鍵
                {
                    if (txtPW.Text == "111") //若密碼正確
                    {
                        lblMsg.Text = "請輸入提款金額後按下 Enter 鍵";
                        txtPW.Enabled = false;  //密碼不能輸入
                        txtMoney.Enabled = true;    //金額可以輸入
                        txtMoney.Focus();   //金額文字方塊取得焦點

                    }
                    else
                    {
                        lblMsg.Text = "密碼錯誤！請再試一次";
                        txtPW.SelectAll();  //選取所有字元
                    }
                }
                else if ((byte)e.KeyChar != 8)   	//若不是退位鍵
                {
                    lblMsg.Text = "請按數字鍵";
                    e.Handled = true;       //不接收字元
                   }
  
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((byte)e.KeyChar < 48 || (byte)e.KeyChar > 57)   //若小於0或大於9
            {

                if (e.KeyChar == (char)Keys.Enter)   	//若是Enter鍵
                {
                    lblMsg.Text = "您的提款金額為 " + txtMoney.Text + " 元";
                    txtMoney.Enabled = false;
                }
                else if (e.KeyChar != (char)Keys.Back)	//若不是退位鍵
                {
                    lblMsg.Text = "請按數字鍵";
                    e.Handled = true;   	//不接收字元
                }

            }
        }
    }
}
