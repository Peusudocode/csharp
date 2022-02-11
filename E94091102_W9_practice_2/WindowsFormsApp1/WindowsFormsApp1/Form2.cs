using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int index = 10;
        Button[] Spectrum = new Button[40];
        int sec = 1;
        int column1, column2, column3, column4;
        int last_button;
        private void Form2_Load(object sender, EventArgs e)
        {
            // 指定滑桿的最小值，剛好為陣列索引下限
            trackBar1.Minimum = 1;
            // 指定滑桿的最大值，剛好為陣列索引上限
            trackBar1.Maximum = 10;

            int x = 0, y = 0;

            for (int i = 0; i < 40; i++)
            {
                if (x % 4 == 0)
                {
                    y++;
                    x = 0;
                }
                index = i;
                Spectrum[i] = new Button();
                Spectrum[i].SetBounds((100 + 105 * x), (30 + 30 * y), 100, 25);//(starting point X, starting point Y, width, heighth)
                Spectrum[i].BackColor = Color.Transparent;
                Controls.Add(Spectrum[i]);
                Spectrum[i].Enabled = false;
                x++;
            }
            timer1.Interval = 500;
            set_button();
            
        }
        private void set_button()
        {
            Random rnd1 = new Random(Guid.NewGuid().GetHashCode());
            Random rnd2 = new Random(Guid.NewGuid().GetHashCode());
            Random rnd3 = new Random(Guid.NewGuid().GetHashCode());
            Random rnd4 = new Random(Guid.NewGuid().GetHashCode());
            column1 = rnd1.Next(1, index);
            column2 = rnd2.Next(1, index);
            column3 = rnd3.Next(1, index);
            column4 = rnd4.Next(1, index);
            last_button = 36;

            for (int i = 1; i < 11; i++)
            {
                if (last_button < 0)
                {
                    break;
                }
                if (i <= column1)
                {
                    Spectrum[last_button].BackColor = Color.Blue;
                    last_button -= 4;
                }
                else if (i > column1)
                {
                    Spectrum[last_button].BackColor = Color.Transparent;
                    last_button -= 4;
                }
            }
            last_button = 37;
            for (int i = 1; i < 11; i++)
            {
                if (last_button < 0)
                {
                    break;
                }
                if (i <= column2)
                {
                    Spectrum[last_button].BackColor = Color.Blue;
                    last_button -= 4;
                }
                else if (i > column2)
                {
                    Spectrum[last_button].BackColor = Color.Transparent;
                    last_button -= 4;
                }
            }
            last_button = 38;
            for (int i = 1; i < 11; i++)
            {
                if (last_button < 0)
                {
                    break;
                }
                if (i <= column3)
                {
                    Spectrum[last_button].BackColor = Color.Blue;
                    last_button -= 4;
                }
                else if (i > column3)
                {
                    Spectrum[last_button].BackColor = Color.Transparent;
                    last_button -= 4;
                }
            }
            last_button = 39;
            for (int i = 1; i < 11; i++)
            {
                if (last_button < 0)
                {
                    break;
                }
                if (i <= column4)
                {
                    Spectrum[last_button].BackColor = Color.Blue;
                    last_button -= 4;
                }
                else if (i > column4)
                {
                    Spectrum[last_button].BackColor = Color.Transparent;
                    last_button -= 4;
                }
            }
            sec = 1; 
            timer1.Enabled = true;	
            
        } 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            index = trackBar1.Value;  // 取得滑桿的位置值，用來當陣列索引
            timer1.Enabled = false;
            set_button();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            if (sec <= 0)
            {
                timer1.Enabled = false;
                set_button();
            }
        }
    }
}
