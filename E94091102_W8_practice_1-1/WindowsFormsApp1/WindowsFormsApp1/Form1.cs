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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = @"card.map";
        int total_row, total_column;
        Button[] cards = new Button[10];
        int[] card_number_array = new int[10];
        int sec;
        int round = 0;
        int P1_score = 0, P2_score = 0;
        int P1_number, P2_number;
        int P1_index, P2_index;
        int index;
        int remove_card_number= 0;
        DialogResult result;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            StreamReader sr = new StreamReader(filename);
            string data;
            data = sr.ReadLine();
            string[] size_array = data.Split();
            total_row = int.Parse(size_array[0]);
            total_column = int.Parse(size_array[1]);
            card_number_array = new int[total_row * total_column];
            int position = 0;
            do
            {
                data = sr.ReadLine();            // 讀取一行文字資料
                if (data == null) break;         // 若資料讀取完畢，跳離迴圈
                string[] number_array = data.Split();
                for (int i = 0; i < total_column; i++)
                {
                    card_number_array[position + i] = int.Parse(number_array[i]);
                }
                position += total_column;
            } while (true);
            sr.Close();
            timer1.Enabled = false;	 // 暫停計時器
            timer1.Interval = 1000;

        }

        private void set_Button(ref Button[] card, int row, int column, int[] number)
        {
            card = new Button[row * column];
            int totalh = 400, totalw = 400;
            int perh = totalh / row;
            int perw = totalw / column;
            int x = 0, y = 0;

            for (int i = 0; i < (row * column); i++)
            {
                if (x % column == 0)
                {
                    y++;
                    x = 0;
                }
                index = i;
                card[i] = new Button();
                card[i].SetBounds((50 + (perw + 5) * x), (50 + (perh + 5) * y), perw, perh);//(starting point X, starting point Y, width, heighth)
                card[i].BackColor = Color.Blue;
                card[i].Text = number[i].ToString();
                card[i].Click += btn1_Click;
                Controls.Add(card[i]);
                x++;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "第" + round.ToString() + "回合 輪到P1";
            label2.Text = "P2:" + P2_score.ToString() + "分";
            label3.Text = "P1:" + P1_score.ToString() + "分";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = false;
            set_Button(ref cards, total_row, total_column, card_number_array);
            sec = 3;
            timer1.Enabled = true;
            label1.Text = "第1回合 輪到P1"; 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sec -= 1;
            if (sec <= 0 && round == 0)
            {
                timer1.Enabled = false;
                for (int i = 0; i < (total_column * total_row); i++)
                {
                    cards[i].BackColor = Color.Gray;
                    cards[i].Text = "";
                }
                round++;
            }
            else if (sec <= 0 && round != 0)
            {
                timer1.Enabled = false;
                cards[P1_index].Visible = false;
                cards[P2_index].Visible = false;
                
                for (int i = 0; i < (total_column * total_row); i++)
                {
                    cards[i].Enabled = true;
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;   //將sender轉型為按鈕物件btnClick
            int index = Array.IndexOf(cards, btnClick);
            btnClick.BackColor = Color.Blue;
            btnClick.Text = card_number_array[index].ToString();
            btnClick.Enabled = false;
            if (round % 2 == 1)
            {
                if (P1_number == 0)
                {
                    P1_number = card_number_array[index];
                    P1_index = index;
                    label1.Text = "第" + round.ToString() + "回合 輪到P2";
                }
                else
                {
                    P2_number = card_number_array[index];
                    P2_index = index;
                    check();
                }
            }
            else if (round % 2 == 0)
            {
                if (P2_number == 0)
                {
                    P2_number = card_number_array[index];
                    P2_index = index;
                    label1.Text = "第" + round.ToString() + "回合 輪到P1";
                }
                else
                {
                    P1_number = card_number_array[index];
                    P1_index = index;
                    check();
                }
            }
        }

        private void check()
        {
            for (int i = 0; i < (total_column * total_row); i++)
            {
                cards[i].Enabled = false;
            }
            sec = 2;
            timer1.Enabled = true;
            if (P1_number > P2_number && round % 2 == 0)
            {
                P1_score += P1_number - P2_number;
                label3.Text = "P1:" + P1_score.ToString() + "分";
            }
            else if (P1_number < P2_number && round % 2 == 1)
            {
                P2_score += P2_number - P1_number;
                label2.Text = "P2:" + P2_score.ToString() + "分";
            }
            round++;
            P2_number = 0;
            P1_number = 0;
            remove_card_number += 2;
            if (remove_card_number >= (total_column * total_row / 2))
            {
                if (P1_score > P2_score)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP1獲勝了", "", MessageBoxButtons.OK);
                }
                else if (P2_score > P1_score)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP2獲勝了", "", MessageBoxButtons.OK);
                }
                else
                {
                    result = MessageBox.Show("遊戲結束!!!", "", MessageBoxButtons.OK);
                }
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (round % 2 == 1)
                {
                    label1.Text = "第" + round.ToString() + "回合 輪到P1";
                }
                else if (round % 2 == 0)
                {
                    label1.Text = "第" + round.ToString() + "回合 輪到P2";
                }
            }
        }
    }
}

