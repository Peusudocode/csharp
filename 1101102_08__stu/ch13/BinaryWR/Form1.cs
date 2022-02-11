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

namespace BinaryWR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = @"..\..\data.bin";

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(filename);
            string path = finfo.DirectoryName;
            if (!Directory.Exists(path))           // 若指定的來源檔案資料夾不存在
                Directory.CreateDirectory(path);   // 則建立該資料夾
            btnRead.Enabled = false;               // 讀取檔案按鈕失效
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fsOut = new FileStream(filename, FileMode.Create);  // 建立檔案串流
            BinaryWriter bw = new BinaryWriter(fsOut);
            bw.Write(txtPad.Text);
            bw.Flush();                         // 清除緩衝區
            bw.Close();                         // 關閉資料串流
            fsOut.Close();                      // 關閉檔案串流
            btnRead.Enabled = true;             // 讀取檔案按鈕有效
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtPad.Text = "";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fsIn = new FileStream(filename, FileMode.Open); // 開啟檔案輸入串流
            BinaryReader br = new BinaryReader(fsIn);
            txtPad.Text = br.ReadString();
            br.Close();
            fsIn.Close();
        }
    }
}
