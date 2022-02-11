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


namespace CreatePath
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
            if (Directory.Exists(path))     // 若path指定的資料夾存在時
            {
                msg = " 資料夾已存在！";
            }
            else                            // 當path指定的資料夾不存在
            {
                Directory.CreateDirectory(path);　　 // 建立資料夾　　
                msg = " 資料夾建立成功！";
            }
            MessageBox.Show(path + msg, "CreatePath");
        }
    }
}
