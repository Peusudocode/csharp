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


namespace BinaryCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string SourceFile = @"..\..\bridge.jpg";      // 來源圖形檔案
        string DestFile = @"..\..\bridge_b.jpg";   // 目的圖形檔案
        byte[] bufferData;                              // 宣告位元組型別陣列

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fin = new FileStream(SourceFile, FileMode.Open);   // 開啟檔案串流
            BinaryReader br = new BinaryReader(fin);                      // 建立二進位串流讀取器
            long size = br.BaseStream.Length;                             // 資料串流的長度
            bufferData = new byte[size];                                  // 建立位元組陣列
            bufferData = br.ReadBytes((int)size);                         // 將讀取到的資料串流指向bufferData陣列
            picShow.SizeMode = PictureBoxSizeMode.Zoom;                   // 影像以原比例自動調整大小  
            picShow.Image = Image.FromStream(fin);                        // 影像來自檔案串流
            br.Close();                                                   // 關閉資料串流
            fin.Close();                                                  // 關閉檔案串流
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FileStream fout = new FileStream(DestFile, FileMode.Create);  // 建立檔案串流
            BinaryWriter bw = new BinaryWriter(fout);                     // 建立二進位串流寫入器
            bw.Write(bufferData);                             // 將bufferData陣列內容寫入資料串流
            bw.Flush();                                       // 清空緩衝區
            label1.Text = " 已完成複製! .... ";
            bw.Close();                                       // 關閉資料串流
            fout.Close();                                     // 關閉檔案串流
        }
    }
}
