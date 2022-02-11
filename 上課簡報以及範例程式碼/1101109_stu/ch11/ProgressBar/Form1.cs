using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;       // 設定計時器每隔0.1秒觸發一次
            progressBar1.Step = 1;       // 設定進度列每次的增量為1
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            label1.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;	     // 啟動計時器
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;		// 暫停計時器
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label1.Text = progressBar1.Value + " %";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label1.Text = "資料處理完畢";
                timer1.Enabled = false;		// 計時器停止
                progressBar1.Value = 0;
            }
        }
    }
}
