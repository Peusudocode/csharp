using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sum, price, add1, add2;       // 分別為小計、主餐價、薯條升級、飲料升級　　　　
        int num, amt;                     // 分別為數量、總金額

        private void GetAmt()             //自定函式:重新計算目前總金額
        {
            if (chkS.Checked) add1 = 5;     // 薯條加大多5元
            else add1 = 0;                  // 薯條不加大多0元

            if (chkD.Checked) add2 = 5;     // 飲料加大多5元
            else add2 = 0;                  // 飲料不加大多0元

            sum = price + add1 + add2;      // 單筆金額(包括主餐、薯條升級、飲料升級)
            txtSum.Text = sum.ToString();   // 將筆金額顯示在txtSum文字方塊上面
               
            amt = sum * num;                // 購買總金額
            txtAmt.Text = amt.ToString(); 	// 將總金額顯示在txtAmt文字方塊上面
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum.Text = "1";      // 預設數量為1
            rdbM1_CheckedChanged(sender, e);
        }
        // 按A餐選項按鈕觸動此事件
        private void rdbM1_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;             // A餐單價
            GetAmt();               // 呼叫自定函式,重新計算目前總金額
        }
        // 按B號餐選項按鈕觸動此事件
        private void rdbM2_CheckedChanged(object sender, EventArgs e)
        {
            price = 60;            // B餐單價
            GetAmt();              // 呼叫自定函式,重新計算目前總金額
        }
        // 按B號餐選項按鈕觸動此事件
        private void rdbM3_CheckedChanged(object sender, EventArgs e)
        {
            price = 50;            // C餐單價
            GetAmt();              // 呼叫自定函式,重新計算目前總金額
        }
        // 副餐框架內
        private void rdbS1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbS1.Checked)         // 當薯條選項按鈕被選取，
                chkS.Enabled = true;   // 薯條加大核取方塊允許被選取
            else                       // 當薯條選項按鈕未被選取
            {
                chkS.Enabled = false;  // 薯條加大核取方塊不允許選取
                chkS.Checked = false;  // 薯條加大核取方塊設成不勾選
            }
        }
        // 當薯條加大核取方塊有異動觸動此事件
        private void chkS_CheckedChanged(object sender, EventArgs e)
        {
            GetAmt();                  // 呼叫自定函式
        }
        // 當飲料加大核取方塊有異動觸動此事
        private void chkD_CheckedChanged(object sender, EventArgs e)
        {
            GetAmt();                  // 呼叫自定函式
        }
        // 當輸入的數量有異動觸動此事件
        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            try { num = int.Parse(txtNum.Text); }
            catch { return; }
            if (num <= 0) return;
            GetAmt();                  // 呼叫自定函式
        }
    }
}
