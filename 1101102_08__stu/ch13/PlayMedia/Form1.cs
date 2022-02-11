using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MediaPlayer1.URL = @"Dog.wmv";     // 多媒檔的路徑檔名
            MediaPlayer1.Ctlcontrols.stop();           // 停止播放
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.play();           // 播放
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.pause();          // 暫停
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();           // 停止
        }
    }
}
