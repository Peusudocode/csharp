using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceMultiFormList
{
    public partial class loginForm : Form
    {
        public bool logined;
        public string acnt;
        public loginForm()
        {
            InitializeComponent();

            this.logined = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtAcnt.Text == "admin" && txtPwd.Text == "0000")
            {
                this.logined = true;
                this.acnt = txtAcnt.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPwd.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
