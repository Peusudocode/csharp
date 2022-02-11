using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiText
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        int num = 0;      // 記錄密碼輸入次數

        private void btnOK_Click(object sender, EventArgs e)
        {
            num++;           // 密碼輸入次數+1
            //若ID = "happy" 且 Password = "168"
            if (txtID.Text == "11" && txtPassword.Text == "00")
                this.Close();   // 關閉目前(frmPW)表單
            else
            {
                if (num < 3)   // 若輸入次數<3
                {
                    DialogResult result = MessageBox.Show("是否再輸入？",
                      "密碼錯誤", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        txtID.Clear(); txtPassword.Clear();    // 清空文字方塊
                        txtID.Focus();     // 使txtID成為作用物件
                    }
                    else
                        Application.Exit();  // 使用者不想輸入結束程式
                }
                else
                    Application.Exit();       // 輸入次數=3結束程式
            }
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}
