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

namespace StreamReader1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = @"..\..\..\test_path\apple.txt";

        private void btnChar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filename);
            char ch;
            do
            {
                ch = (char)sr.Read();           // 讀取一個字元資料
                if (sr.Peek() == -1) break;     // 若資料讀取完畢，跳離迴圈
                txtShow.Text += ch;             // 顯示讀取的資料
                DialogResult result;
                result = MessageBox.Show("按 <是> 鈕 繼續輸出 \n 按 <否> 鈕 離開 ", "是否繼續 ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
            } while (true);
            sr.Close();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filename);
            string data;

            do
            {
                data = sr.ReadLine();            // 讀取一行文字資料
                if (data == null) break;         // 若資料讀取完畢，跳離迴圈
                txtShow.Text += data + "\r\n";   // 顯示所讀取的資料
                DialogResult result;
                result = MessageBox.Show("按 <是> 鈕 繼續輸出 \n 按 <否> 鈕 離開 ", "是否繼續 ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;
            } while (true);
            sr.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filename);
            txtShow.Text = sr.ReadToEnd();     // 讀取整個檔案資料並顯示出來
            sr.Close();
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";                 // 清除已顯示的文字內容
        }
    }
}
