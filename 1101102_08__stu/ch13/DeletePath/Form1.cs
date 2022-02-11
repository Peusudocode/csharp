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

namespace DeletePath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"..\..\..\test_path八七\";
            string msg;
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                msg = path + " 資料夾已刪除！";
            }
            else
            {
                msg = "要刪除的資料夾 " + path + " 不存在！";
            }
            MessageBox.Show(msg, "DeletePath");
        }
    }
}
