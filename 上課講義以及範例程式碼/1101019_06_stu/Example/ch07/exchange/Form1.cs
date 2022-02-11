using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int change;               // 零錢總金額
        
        private void exchange()   //自定函式:用來兌換零錢
        {
            txt50.Clear();        // 將存放50元找零個數位置清成空白
            txt10.Clear();        // 將存放10元找零個數位置清成空白
            txt5.Clear();         // 將存放5元找零個數位置清成空白
            txt1.Clear();         // 將存放1元找零個數位置清成空白
            int remain = change;  // 兌換後的餘額

            if (chk50.Checked == true)
            {
                txt50.Text = (remain / 50).ToString();  // 取得50元兌換數
                remain = remain % 50;                   // 兌換後剩餘金額
            }
            if (chk10.Checked == true)
            {
                txt10.Text = (remain / 10).ToString();  // 取得10元兌換數
                remain = remain % 10;                   // 兌換後剩餘金額
            }
            if (chk5.Checked == true)
            {
                txt5.Text = (remain / 5).ToString();    // 取得5元兌換數
                remain = change % 5;                    // 兌換後剩餘金額
            }
            txt1.Text = remain.ToString();              // 取得1元兌換數
        }
        
        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                change = int.Parse(txtMoney.Text);
            }
            catch
            {
                MessageBox.Show("請輸入正整數值！", "錯誤訊息", MessageBoxButtons.OK);
                return;
            }
            if (change < 0)
            {
                MessageBox.Show("請輸入正整數值！", "錯誤訊息", MessageBoxButtons.OK);
                return;
            }
            exchange();    // 呼叫自定函式,兌換零錢
        }

        private void chk50_CheckedChanged(object sender, EventArgs e)
        {
            exchange();   // 呼叫自定函式,兌換零錢
        }

        private void chk10_CheckedChanged(object sender, EventArgs e)
        {
            exchange();   // 呼叫自定函式,兌換零錢
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            exchange();   // 呼叫自定函式,兌換零錢
        }
    }
}
