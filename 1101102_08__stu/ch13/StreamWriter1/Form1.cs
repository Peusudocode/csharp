using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamWriter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPad.Text = "";
            lblShow.Text = "";
            lblMsg.Text = "";
        }
        // --------- 按 <存檔> 鈕 ----------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] product = new string[10];
            int k = 0;

            foreach (string item in txtPad.Lines)  // 將輸入資料置入陣列
            {
                product[k] = item;
                k++;
            }

            foreach (string item in product)   // 將陣列資料顯示在lblShow標籤控制項上的
                lblShow.Text += item + "\n";

            string filename = @"..\..\..\test_path\apple.txt";   // 指定存入的文字檔檔名
            FileInfo finfo = new FileInfo(filename);

            if (!Directory.Exists(finfo.DirectoryName))  // 檢查路徑和檔名是否存在
                Directory.CreateDirectory(finfo.DirectoryName); // 不存在則建立

            StreamWriter sw = finfo.CreateText();

            sw.WriteLine(txtPad.Text);
            sw.Flush();
            sw.Close();
            lblMsg.Text = " 資料已存入 ! ...";
        }
        // ------ 按 <加入> 鈕 -------------------------------------------------------------------------
        private void btnAppend_Click(object sender, EventArgs e)
        {
            string filename = @"..\..\..\test_path\apple.txt";   // 指定存入的文字檔檔名
            FileInfo finfo = new FileInfo(filename);
            StreamWriter sw = finfo.AppendText();
            sw.Write(txtPad.Text);
            sw.Flush();
            sw.Close();
            lblMsg.Text = " 資料已加入 ! ...";
            txtPad.Text = "";
        }
        // ----------- 按 <清除> 鈕 -----------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPad.Text = "";
            lblMsg.Text = "";
            lblShow.Text = "";
        }
        // ---------- 按 <結束> 鈕 ------------------------------------------------------
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();   // 結束程式執行
        }
    }
}
