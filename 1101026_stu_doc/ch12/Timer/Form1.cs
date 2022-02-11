using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int min, sec, num;    // 分,秒,倒數

        private void Reset()
        {
            txtMin.Clear();
            txtSec.Clear();
            lblRSec.Text = "";
            min = 0; sec = 0; num = 0;
            btnStart.Enabled = false;
            timer1.Enabled = false;	     // 暫停計時器
            timer1.Interval = 1000;//(1秒)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            try     // 檢查輸入值是否為數值？
            {
                min = int.Parse(txtMin.Text);   // 轉成分數
                lblRSec.Text = "";
            }
            catch { Reset(); }                       // 若輸入資料不符, 重新執行
            if ((min < 0) || (min > 59))  Reset();   // 若數量範圍不符, 重新執行
            else  num = min * 60 + sec;
        }

        private void txtSec_TextChanged(object sender, EventArgs e)
        {
            try     // 檢查輸入值是否為數值？
            {
                sec = int.Parse(txtSec.Text);   // 轉成秒數
                lblRSec.Text = "";
            }
            catch { Reset(); }                     // 若輸入資料不符, 重新執行
            if ((sec < 0) || (sec > 59)) Reset();  // 若數量範圍不符,  重新執行
            else
            {
                num = min * 60 + sec;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;	     // 啟動計時器
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRSec.Text = num.ToString();
            if (num == 0)
            {
                timer1.Enabled = false;
                btnStart.Enabled = false;
                MessageBox.Show("時間到！", "時間倒數器", MessageBoxButtons.OK);
            }
            num--;
        }
    }
}
