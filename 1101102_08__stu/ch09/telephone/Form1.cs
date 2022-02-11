using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telephone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] tel = new string[] { "105：查號台", "108：長途台", "110：報案台", "117：報時台", "166：氣象台" };

        private void Form1_Load(object sender, EventArgs e)
        {
            vsbTel.Minimum = 0; //設定vsbTel的最小值=0(註標值由0開始)
            vsbTel.Maximum = tel.Count() - 1; //設定vsbTel的最大值=陣列元素個數-1
            vsbTel.LargeChange = 1;//設LargeChange = 1使Value能達最大值
            hsbWidth.Minimum = 100; hsbWidth.Maximum = 300;//設hsbWidth的最小、最大值
            txtTel.Text = tel[0];//設txtTel顯示第1個陣列元素值
        }

        private void vsbTel_Scroll(object sender, ScrollEventArgs e)
        {
            txtTel.Text = tel[vsbTel.Value];//設txtTel顯示Value對應的陣列元素值
            hsbWidth.Value = 100;//設hsbWidth的Value屬性值 = 100
            txtTel.Width = 100;//設txtTel的寬度 = 100
        }

        private void hsbWidth_Scroll(object sender, ScrollEventArgs e)
        {
            txtTel.Width = hsbWidth.Value;//設txtTel的寬度 =hsbWidth的Value值
        }
    }
}
