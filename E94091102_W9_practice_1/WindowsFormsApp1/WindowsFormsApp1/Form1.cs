using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class MusicPlayer : SoundPlayer
        {
            public bool Loop = false;
            public string[] Playlist;

            public string SelectWavFiles;

            public void Play()
            {
                SoundPlayer player1 = new SoundPlayer();        // 建立播放器物件
                player1.SoundLocation = SelectWavFiles;           // 指定音效所在路徑檔名
                player1.Load();                                 // 載入音效檔資料
                if (Loop == false)
                {
                    player1.Play();
                }
                else if (Loop == true)
                {
                    player1.PlayLooping();
                }
                
            }
            public void Stop()
            {
                if (SelectWavFiles != null)
                {
                    FileStream fIn = new FileStream(SelectWavFiles, FileMode.Open);
                    SoundPlayer player3 = new SoundPlayer(fIn);      // 使用檔案串流建立物件
                    player3.Stop();                          // 停止播放
                    fIn.Close();　　                                 // 關閉串流
                }
                
            }

            // public void SetMusicLocation(string path)

            // public void Saveplaylist()

            // public string[] LoadPlaylist()
        }

        MusicPlayer MP3 = new MusicPlayer();
        int Playlist_Length;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true; //設定Form1為父表單
            //設定篩選字串為只能顯示WAV格式檔案
            openFileDialog1.Filter = "WAV(*.wav)|*.wav";
            openFileDialog1.Multiselect = true; //允許選取多檔案
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MP3.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                foreach (string strFilename in openFileDialog1.FileNames)
                {
                    list.Add(strFilename);
                    MP3.Playlist = list.ToArray();
                }
                Playlist_Length = MP3.Playlist.Length;
                if (Playlist_Length > 0)
                {
                    radioButton1.Text = MP3.Playlist[0];
                    radioButton1.Visible = true;
                }
                if (Playlist_Length > 1)
                {
                    radioButton2.Text = MP3.Playlist[1];
                    radioButton2.Visible = true;
                }
                if (Playlist_Length > 2)
                {
                    radioButton3.Text = MP3.Playlist[2];
                    radioButton3.Visible = true;
                }
                if (Playlist_Length > 3)
                {
                    radioButton4.Text = MP3.Playlist[3];
                    radioButton4.Visible = true;
                }
            }
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MP3.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Loop = true;
        }
    }
}
