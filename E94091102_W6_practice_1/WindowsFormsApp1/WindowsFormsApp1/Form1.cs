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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h, w, number, check;
        Button[] b =  new Button[10];
        Button[] a =  new Button[10];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            check = 1;
            
            try
            {
                number = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                check = 0;
                for (int i = 0; i < h * w; i++)
                {
                    a[i].BackColor = Color.White;
                    b[i].BackColor = Color.White;
                }
            }
            if ( number < -9 || number > 99)
            {
                MessageBox.Show("請輸入範圍內的數字");
                textBox3.Text = "";
                check = 0;
                for (int i = 0; i < h * w; i++)
                {
                    a[i].BackColor = Color.White;
                    b[i].BackColor = Color.White;
                }
            }
            if (check == 1)
            {
                for (int i = 0; i < h*w; i++)
                {
                    a[i].BackColor = Color.White;
                    b[i].BackColor = Color.White;
                }
                shine(number, ref a, ref b, h, w);
            }
        }
        private void shine(int number, ref Button[] a, ref Button[] b, int h, int w)
        {
            int a_number, b_number;
            if (number >= 0)
            {
                a_number = number % 10;
                print(ref a, a_number, h, w);
                b_number = (number/10) % 10;
                if(b_number > 0)
                {
                    print(ref b, b_number, h, w);
                }
            }
            if (number < 0)
            {
                a_number = 0 - number;
                print(ref a, a_number, h, w);
                int j = w * (h / 2) + 1;
                for (int i =1; i < (w-1); i++)
                {
                    b[j].BackColor = Color.Blue;
                    j++;
                }
            }
        }
        private void print(ref Button[] k, int number, int h, int w)
        {
            if(number == 0)
            {
                for (int i = 1; i < (w-1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int j = w;
                int l = 2 * w - 1;
                for (int i = 0; i < (h-2)*2; i++)
                {
                   
                    if (i % 2 == 0)
                    {
                        k[j].BackColor = Color.Blue;
                        j += w;
                    }
                    if (i % 2 == 1)
                    {
                        k[l].BackColor = Color.Blue;
                        l += w;
                    }
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w-2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
            }
            else if (number == 1)
            {
                int j = 2 * w - 1;
                for (int i = 0; i < (h-3)/2; i++)
                {
                    k[j].BackColor = Color.Blue;
                    j += w;
                }
                int p = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
            }
            else if (number == 2)
            {
                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w - 2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {
                    
                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int p = 2 * w - 1; 
                for (int i = 0; i < (h-3)/2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
                int o = (h / 2 + 1) * w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }
            }
            else if(number == 3)
            {

                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w - 2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {

                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int p = 2 * w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
                int o = (h / 2 + 1) * w + w -1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }
            }
            else if ( number == 4)
            {
                int p = 2 * w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
                int o = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {

                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int l = w;
                for(int i = 0; i < (h - 3) / 2; i++)
                {
                    k[l].BackColor = Color.Blue;
                    l += w;
                }
            }
            else if (number == 5)
            {
                int l = w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[l].BackColor = Color.Blue;
                    l += w;
                }
                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w - 2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {

                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int o = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }

            }
            else if (number == 6)
            {
                int l = w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[l].BackColor = Color.Blue;
                    l += w;
                }
                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w - 2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {

                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int o = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }
                int q = (h / 2 + 1) * w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[q].BackColor = Color.Blue;
                    q += w;
                }
            }
            else if ( number == 7)
            {
                int j = 2 * w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[j].BackColor = Color.Blue;
                    j += w;
                }
                int p = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
            }
            else if (number == 8)
            {
                int l = w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[l].BackColor = Color.Blue;
                    l += w;
                }
                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w - 2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {

                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int o = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }
                int q = (h / 2 + 1) * w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[q].BackColor = Color.Blue;
                    q += w;
                }
                int p = 2 * w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
            }
            else if (number == 9)
            {
                int l = w;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[l].BackColor = Color.Blue;
                    l += w;
                }
                for (int i = 1; i < (w - 1); i++)
                {
                    k[i].BackColor = Color.Blue;
                }
                int g = w * (h - 1) + 1;
                for (int i = 0; i < w - 2; i++)
                {
                    k[g].BackColor = Color.Blue;
                    g++;
                }
                int j = w * (h / 2) + 1;
                for (int i = 1; i < (w - 1); i++)
                {

                    k[j].BackColor = Color.Blue;
                    j++;
                }
                int o = (h / 2 + 1) * w + w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[o].BackColor = Color.Blue;
                    o += w;
                }
                int p = 2 * w - 1;
                for (int i = 0; i < (h - 3) / 2; i++)
                {
                    k[p].BackColor = Color.Blue;
                    p += w;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (h > 0 && w > 0)
            {
                for (int i = 0; i < w * h; i++)
                {
                    Controls.Remove(a[i]);
                    Controls.Remove(b[i]);
                }
            }
            check = 1;
            try
            {
                h = int.Parse(textBox1.Text);
                w = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                textBox1.Text = "";
                textBox2.Text = "";
                check = 0;
            }
            if ( h < 7 || h > 15)
            {
                MessageBox.Show("請輸入範圍內的數字");
                textBox1.Text = "";
                check = 0;
            }
            else if ( h%2 == 0)
            {
                MessageBox.Show("高不能為偶數");
                textBox1.Text = "";
                check = 0;
            }
            if ( w < 5 || w > 10)
            {
                MessageBox.Show("請輸入範圍內的數字");
                textBox2.Text = "";
                check = 0;
            }
            if (check == 1 )
            {

                textBox3.Visible = true;
                set_Button(ref a, ref b, w, h);
                if (textBox3.Text != "")
                {
                    shine(number, ref a, ref b, h, w);
                }
            }
        }
        private void set_Button(ref Button[] a, ref Button[]b, int w, int h)
        {
            b = new Button[w * h];
            a = new Button[w * h];
            int totalh = 300, totalw = 250;
            int perh = totalh / h;
            int perw = totalw / w;
            int x = 0, y = 0;

            for (int i = 0; i < (w * h); i++)
            {
                if (x % w == 0)
                {
                    y++;
                    x = 0;
                }
                b[i] = new Button();
                b[i].SetBounds((180 + (perw + 5) * x), (40 + (perh + 5) * y), perw, perh);//(starting point X, starting point Y, width, heighth)
                b[i].BackColor = Color.White;
                Controls.Add(b[i]);
                x++;
            }
            x = 0;
            y = 0;
            for (int i = 0; i < (w * h); i++)
            {
                if (x % w == 0)
                {
                    y++;
                    x = 0;
                }
                a[i] = new Button();
                a[i].SetBounds((480 + (perw + 5) * x), (40 + (perh + 5) * y), perw, perh);//(starting point X, starting point Y, width, heighth)
                a[i].BackColor = Color.White;
                Controls.Add(a[i]);
                x++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
      
            textBox3.Visible = false;
            if (textBox3.Visible)
            {
                number = int.Parse(textBox3.Text);
                MessageBox.Show(textBox3.Text);
            }
        }
    }
}
