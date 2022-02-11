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
        }

        Form2 F2 = new Form2();
        MusicPlayer MP3 = new MusicPlayer();
        int Playlist_Length;
        string file = "";
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
            fontDialog1.MinSize = 12;       //設字型對話方塊中可以設定字型最小值
            fontDialog1.MaxSize = 24;       //設字型對話方塊中可以設定字型最大值
            colorDialog1.FullOpen = true;   //設色彩對話方塊中自動開啟自訂色彩色盤
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MP3.Play();
            if (MP3.Loop == true)
            {
                F2.Show();             // 用強制回應對話方塊方式來顯示frmPW表單
            }
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
            if (MP3.Loop == true)
            {
                F2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton2.Text;
            if (MP3.Loop == true)
            {
                F2.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton3.Text;
            if (MP3.Loop == true)
            {
                F2.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Stop();
            MP3.SelectWavFiles = radioButton3.Text;
            if (MP3.Loop == true)
            {
                F2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MP3.Stop();
            if(MP3.Loop == true)
            {
                F2.Visible = false;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MP3.Loop = true;
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Playlist_Length == 0)
            {
                MessageBox.Show("請先建立撥放清單");
            }
            else
            {

                for (int i = 0; i < Playlist_Length; i++)
                {
                    file += MP3.Playlist[i] + "\n";
                }
                file.Trim('\n');
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "文字檔案(*.txt)|*.txt|所有檔案|*.*";//設定檔案型別
                saveFileDialog1.FileName = "播放清單";//設定預設檔名
                saveFileDialog1.DefaultExt = "txt";//設定預設格式（可以不設）
                saveFileDialog1.AddExtension = true;//設定自動在檔名中新增副檔名
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine(file);
                    }
                    MessageBox.Show("檔案複製成功 !.....");
                }

            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //當使用者在色彩對話方塊中按確定鈕時
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {   //設btnDesign背景色和色彩對話方塊設定的色彩相同
                radioButton1.ForeColor = colorDialog1.Color;
                radioButton2.ForeColor = colorDialog1.Color;
                radioButton3.ForeColor = colorDialog1.Color;
                radioButton4.ForeColor = colorDialog1.Color;
            }
        }

        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //當使用者在字型對話方塊中按確定鈕時
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   //設btnDesign和字型對話方塊設定的字型相同
                radioButton1.Font = fontDialog1.Font;
                radioButton2.Font = fontDialog1.Font;
                radioButton3.Font = fontDialog1.Font;
                radioButton4.Font = fontDialog1.Font;
            }
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文字檔案(*.txt)|*.txt|所有檔案|*.*";//設定檔案型別 
            openFileDialog1.Title = "開啟檔案"; //獲取或設定檔案對話方塊標題
            openFileDialog1.RestoreDirectory = true;
            string Text;
            string Text_2 = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(filename);
                do
                {
                    Text = sr.ReadLine();            // 讀取一行文字資料
                    if (Text == null) break;         // 若資料讀取完畢，跳離迴圈
                    Text_2 += Text + "\n";
                } while (true);
                Text_2.TrimEnd('\n');
                MP3.Playlist = Text_2.Split('\n');
                Playlist_Length = MP3.Playlist.Length;
                MP3.Playlist = MP3.Playlist.Where(w => w != MP3.Playlist[Playlist_Length - 1]).ToArray();
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
    }
}
