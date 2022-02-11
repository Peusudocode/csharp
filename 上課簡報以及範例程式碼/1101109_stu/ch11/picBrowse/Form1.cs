using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picBrowse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true; //設定Form1為父表單
            //設定篩選字串為只能顯示.jpg、.bmp、.gif和.png格式檔案
            openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png";
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {   //若在開檔對話方塊中按確定鈕
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Picture frmPic = new Picture();  	// 宣告frmPic為表單實體
                    frmPic.MdiParent = this;      // 指定父表單
                    frmPic.Text = openFileDialog1.FileName;//設定子表單標題文字
                    //子表單背景圖指定為開檔對話方塊指定的檔案
                    frmPic.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                    frmPic.Show();    // 顯示子表單
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請選取適當格式的圖檔", "注意");
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form actForm = this.ActiveMdiChild;
                actForm.BackgroundImage.Save(saveFileDialog1.FileName);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
