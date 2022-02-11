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

namespace MovePath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string SourcePath = @"..\..\..\test_path107\";
            string DestPath = @"..\..\..\test_path_107_b\";
            string msg;
            if (Directory.Exists(SourcePath))
            {
                Directory.Move(SourcePath, DestPath);
                msg = "資料夾已成功搬移到 " + DestPath + " 資料夾！";
            }
            else
            {
                msg = "來源資料夾 " + SourcePath + " 不存在！";
            }
            MessageBox.Show(msg, "MovePath");
        }
    }
}
