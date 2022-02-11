using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0; 　// 存放購買金額
        int qty = 1;       // 購買數量
        String item;     // 存放被勾選的產品名稱

        private void Form1_Load(object sender, EventArgs e)
        {
            chk1.Checked = true; // 預設勾選 iPad2 核取方塊
            lblMsg.ForeColor = Color.Red;
            lblMsg.BackColor = SystemColors.Highlight;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            lblMsg.Font = new Font("標楷體", 14, FontStyle.Italic);
        }
        // 當iPad2 核取方塊被勾選時觸動此事件
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked)        // 若ipad2被勾選執行下面程式區段
            {
                item = "iPadpro";      // 存放 iPad2 品名  
                lblMsg.Text = "";    // 訊息清成空白
              //  chk1.AutoCheck = false;  // iPad2核取方塊設成被按下時無法自動變更狀態
               chk2.AutoCheck = true;   // iPad Mini核取方塊被按下時設成可自動變更狀態
                chk3.AutoCheck = true;   // iPhone5核取方塊被按下時設成可自動變更狀態
                chk2.Checked = false;    // iPad Mini核取方塊設成未被勾選
             //   chk3.Checked = false;    // iPhone5核取方塊設成未被勾選              
                txtQty.Focus();          // 將游標移到數量文字方塊上
                txtQty.Text = "1";         // 將數量預設為1台              
            }        
        }
        // 當iPad2 核取方塊被勾選時觸動此事件
        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked)
            {
                item = "iPad Mini";
                lblMsg.Text = "";
           //     chk1.AutoCheck = true;
                chk2.AutoCheck = false;
         //       chk3.AutoCheck = true;
                chk1.Checked = false;
                chk3.Checked = false;
                txtQty.Text = "";
                txtQty.Focus();
                txtQty.Text = "1";
            }
        }
        // 當iPhone5 核取方塊被勾選時觸動此事件
        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked)
            {
                item = "iPhone7";
                lblMsg.Text = "";
         //       chk1.AutoCheck = true;
       //         chk2.AutoCheck = true;
      //         chk3.AutoCheck = false;
                chk1.Checked = false;
                chk2.Checked = false;
                txtQty.Focus();
                txtQty.Text = "1";
            }
        }
        // 當結帳按鈕被按下時觸動此事件
        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                qty = int.Parse(txtQty.Text);  // 將數量文字方塊的輸入值由字串轉成整數
            }
            catch    // 當qty 出現錯誤時執行下面程式區段
            {
                lblMsg.Text = "";
                MessageBox.Show("請輸入正整數值！", "錯誤訊息", MessageBoxButtons.OK);
                txtQty.Text = "1";
                return;
            }
            if (qty <= 0) // 當qty 數量沒有大於零時執行下面程式區段
            {
                lblMsg.Text = "";   // 將訊息顯示區清成空白
                MessageBox.Show("不能為負整數值！", "錯誤訊息", MessageBoxButtons.OK);
                txtQty.Text = "1";  // 購買數量輸入區預設一台                
                return;
            }

            if (chk1.Checked) total = 12500 * qty;   // 被勾選才顯示購買金額置入total變數

            if (chk2.Checked) total = 10500 * qty;   // 被勾選才顯示購買金額置入total變數

            if (chk3.Checked) total = 21900 * qty;  // 被勾選才顯示購買金額置入total變數
            // 將購買總金額顯示在lblMsg標籤控制項上
            lblMsg.Text = "你購買 " + item + " " + qty.ToString() + "台 共計:NT$" + total.ToString("#,#") + "元";   
         }
    }
}
