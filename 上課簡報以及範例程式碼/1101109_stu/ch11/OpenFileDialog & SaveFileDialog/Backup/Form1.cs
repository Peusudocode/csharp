using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;   //引用System.IO命名空間

namespace cs_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Delete(saveFileDialog1.FileName);
                File.Copy(txtSource.Text, saveFileDialog1.FileName);
                MessageBox.Show("檔案複製成功 !.....");
            }
        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            string fPath = Path.GetFullPath(txtSource.Text);
            FileInfo fInfo = new FileInfo(txtSource.Text);
            lblFileInfoName.Text = " 1. 檔　　名 : "
                + fInfo.Name;
            lblFileInfoDirectoryName.Text = " 2. 路　　徑 : "
                + fInfo.DirectoryName;
            lblFileInfoSize.Text = " 3. 檔案大小 : "
                + fInfo.Length.ToString() + " bytes";
            lblFileInfoCreationTime.Text = " 4. 建檔時間 : "
                + fInfo.CreationTime;
            lblFileInfoLastAccessTime.Text = " 5. 最近存取時間 :"
                + fInfo.LastAccessTime;
            lblFileInfoLastWriteTime.Text = " 6. 最近寫入時間 :"
                + fInfo.LastWriteTime;
            lblFileAttributeHidden.Text = " 7. 隱藏檔 : "
                + ((fInfo.Attributes & FileAttributes.Hidden) != 0).ToString();
            lblFileAttributeReadOnly.Text = " 8. 唯讀檔 : "
                + ((fInfo.Attributes & FileAttributes.ReadOnly) != 0).ToString();
            lblFileAttributeSystem.Text = " 9. 系統檔 : "
                + ((fInfo.Attributes & FileAttributes.System) != 0).ToString();
            lblFileAttributeOffline.Text = "10.離　線 : "
                + ((fInfo.Attributes & FileAttributes.Offline) != 0).ToString();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

