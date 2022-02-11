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

namespace FileOperate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定第一個操作畫面
            txtDest.Enabled = false;     // 目的檔案文字方塊失效
            txtShow.ReadOnly = true;     // 訊息文字方塊唯讀
            txtShow.Text = "請輸入「來源檔案」完整名稱後，按 [建立] 鈕。";
            btnCopy.Enabled = false;     // 複製按鈕失效
            btnDelete.Enabled = false;   // 刪除按鈕失效
            btnMove.Enabled = false;     // 搬移按鈕失效
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = txtSource.Text;
            FileInfo fInfo = new FileInfo(filename);
            string path = fInfo.DirectoryName;
            if (!Directory.Exists(path))           // 若指定的來源檔案資料夾不存在
                Directory.CreateDirectory(path);    // 則建立該資料夾
            if (fInfo.Exists)                   // 若來源檔案存在，顯示訊息
                txtShow.Text = fInfo.Name + " 檔案已存在！";
            else                               // 若來源檔案不存在，建立檔案
            {
                FileStream fs = fInfo.Create();   // 建立檔案串流物件fs，開啟檔案                 
                txtShow.Text = fInfo.FullName + " 檔案建立成功！";
                fs.Close();                    // 關閉檔案
            }
            // 設定第二個操作畫面
            btnCreate.Enabled = false;　　　　　// 建立按鈕失效
            btnCopy.Enabled = true;             // 複製按鈕有效
            txtDest.Enabled = true;             // 目的檔案文字方塊有效　　　　
            txtSource.Enabled = false;          // 來源檔案文字方塊失效
            txtShow.Text += "\r\n\r\n\r\n";
            txtShow.Text += "再來\r\n";
            txtShow.Text += "輸入「目的檔案」完整名稱後，按 [複製] 鈕。";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FileInfo SourceInfo = new FileInfo(txtSource.Text);
            FileInfo DestInfo = new FileInfo(txtDest.Text);
            string path = DestInfo.DirectoryName;
            if (!Directory.Exists(path))              // 若指定的目的檔案資料夾不存在
                Directory.CreateDirectory(path);       // 則建立該資料夾
            SourceInfo.CopyTo(txtDest.Text, true);     // 將來源檔案拷貝到目的檔案
            txtShow.Text = SourceInfo.FullName + " 檔案成功複製給\r\n";
            txtShow.Text += DestInfo.FullName;
            // 設定第三個操作畫面
            btnCopy.Enabled = false;             // 複製按鈕失效
            btnDelete.Enabled = true;            // 刪除按鈕有效
            txtDest.Enabled = false;             // 目的檔案文字方塊失效
            txtShow.Text += "\r\n\r\n\r\n";
            txtShow.Text += "接著\r\n";
            txtShow.Text += "按 [刪除] 鈕，刪除「目的檔案」指定的檔案。";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FileInfo DestInfo = new FileInfo(txtDest.Text);
            DestInfo.Delete();                // 刪除檔案 
            txtShow.Text = DestInfo.FullName + " 檔案成功刪除。";
            txtDest.Text = "";
            // 設定第四個操作畫面
            btnDelete.Enabled = false;        // 刪除按鈕有效
            btnMove.Enabled = true;           // 搬移按鈕失效
            txtDest.Enabled = true;           // 目的檔案文字方塊有效
            txtShow.Text += "\r\n\r\n\r\n";
            txtShow.Text += "最後\r\n";
            txtShow.Text += "輸入「目的檔案」完整名稱後，按 [搬移] 鈕";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            FileInfo SourceInfo = new FileInfo(txtSource.Text);
            FileInfo DestInfo = new FileInfo(txtDest.Text);
            string path = DestInfo.DirectoryName;
            if (!Directory.Exists(path))          // 若指定的目的檔案資料夾不存在
                Directory.CreateDirectory(path);   // 則建立該資料夾
            if (DestInfo.Exists)                   // 若目的檔案存在
                DestInfo.Delete();                 // 則刪除該檔案           
            txtShow.Text = SourceInfo.FullName + " 檔案成功搬移到\r\n";
            txtShow.Text += DestInfo.FullName;
            SourceInfo.MoveTo(txtDest.Text);       // 將來源檔案搬移到目的檔案
            // 設定第五個操作畫面
            txtSource.Text = "";                   // 來源檔案文字方塊設成空白
            txtDest.Enabled = false;               // 目的檔案文字方塊失效
            btnMove.Enabled = false;               // 搬移按鈕失效
            txtShow.Text += "\r\n\r\n\r\n";
            txtShow.Text += "請關閉程式視窗。";
        }
    }
}
