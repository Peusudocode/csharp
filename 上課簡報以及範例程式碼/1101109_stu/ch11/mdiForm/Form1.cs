using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.MdiWindowListItem = mnuWindow;// 子表單名稱清單顯示在mnuWindows項目中
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            Form2 frmChild = new Form2();  	// 宣告frmChild為表單實體
            frmChild.MdiParent = this;      // 指定父表單
            int num = this.MdiChildren.Length;      //取得子表單的數量
            frmChild.Text = "表單 " + num.ToString();//設定子表單標題文字
            frmChild.Show();    // 顯示子表單
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);  // 子表單重疊排列
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);  //子表單水平排列
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);    // 子表單垂直排列
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
