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
using System.Media;

namespace WavPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            String stFilter = "WAV(*.wav)|*.wav";
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer();        // 建立播放器物件
            player1.SoundLocation = txtPath.Text;           // 指定音效所在路徑檔名
            player1.Load();                                 // 載入音效檔資料
            player1.Play();                                 // 播放音效
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(txtPath.Text);   // 使用完整檔名建立物件
            player2.PlayLooping();　　　　　　　　                 // 重複播放
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FileStream fIn = new FileStream(txtPath.Text, FileMode.Open);
            SoundPlayer player3 = new SoundPlayer(fIn);      // 使用檔案串流建立物件
            player3.Stop();　　　　　　　                 　 // 停止播放
            fIn.Close();　　                                 // 關閉串流
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
