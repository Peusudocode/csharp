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
    public partial class Form1 : Form
    {
        private bool logined;
        private string[] idList;
        private string[] nameList;
        private int cnt;
        public Form1()
        {
            InitializeComponent();

            this.logined = false;
            this.idList = new string[11];
            this.nameList = new string[11];
            this.cnt = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.logined == false)
            {
                this.Enabled = false;
                loginForm lf = new loginForm();
                lf.ShowDialog();

                if (lf.logined == true)
                {
                    this.labLoginStatus.Text = "歡迎回來，" + lf.acnt;
                    this.btnLogin.Text = "登出";
                    this.logined = true;

                    this.btnAdd.Enabled = true;
                    this.btnDelete.Enabled = true;
                    this.btnQuery.Enabled = true;
                    this.txtID.Enabled = true;
                }

                this.Enabled = true;
            }
            else
            {
                this.logined = false;
                this.labLoginStatus.Text = "尚未登入";
                this.btnLogin.Text = "登入";

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnQuery.Enabled = false;
                this.txtID.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("資料的值不應為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(this.cnt >= 10)
            {
                MessageBox.Show("資料已滿");
                return;
            }

            int idx = Array.IndexOf(this.idList, this.txtID.Text);
            if(idx >= 0)
            {
                MessageBox.Show("該資料已經存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addForm af = new addForm();
            this.Enabled = false;

            af.ShowDialog();

            this.Enabled = true;

            if (af.name == "") return;

            idList[this.cnt] = txtID.Text;
            nameList[this.cnt] = af.name;
            cnt++;

            MessageBox.Show("新增成功", "成功");

            this.txtID.Text = "";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("查詢的值不應為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = Array.IndexOf(this.idList, this.txtID.Text);
            if(idx < 0)
            {
                MessageBox.Show("找不到指定的學號", "查詢結果");
            }
            else
            {
                MessageBox.Show("學號 " + this.txtID.Text + "對應的名字是 " + this.nameList[idx], "查詢結果");
            }

            this.txtID.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("欲刪除的值不應為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = Array.IndexOf(this.idList, this.txtID.Text);

            if(idx < 0)
            {
                MessageBox.Show("找不到指定的學號", "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = idx; i < 10; i++)
            {
                this.idList[i] = this.idList[i + 1];
                this.nameList[i] = this.nameList[i + 1];
            }
            cnt--;

            MessageBox.Show("資料已刪除", "刪除成功");

            this.txtID.Text = "";
        }
    }
}
