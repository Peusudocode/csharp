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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 0;      // 記錄新增文件的次數

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;//新增文件鈕不能使用
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password frmPW = new Password();  // 宣告frmPW為Password表單的物件實體
            frmPW.ShowDialog();             // 用強制回應對話方塊方式來顯示frmPW表單
            btnAdd.Enabled = true;          // 設新增文件鈕可以使用
            btnPassword.Enabled = false;    // 設登入鈕不可以使用
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num++;  //新增文件的次數加1
            Text frmText = new Text();    // 宣告frmText為Text表單的物件實體
            frmText.Text = "文件 "+num.ToString();    //設定表單的標題文字內容
            frmText.Show();               // 顯示frmText表單
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
