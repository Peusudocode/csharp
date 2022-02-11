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
        Button[] btn = new Button[24];
        int sec;
        int score = 0;
        int number = 1;
        int mode;
        DialogResult result;
        int[] button_number = new int[24];
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            score = 0;
            mode = 1;
            label1.Text = "你的分數: " + score.ToString();
            generate_number();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            score = 0;
            label1.Text = "你的分數: " + score.ToString();
            generate_number();
            sec = 3;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            btn[0] = button3; btn[1] = button4; btn[2] = button5; btn[3] = button6;//指定按鈕物件陣列元素
            btn[4] = button7; btn[5] = button8; btn[6] = button9; btn[7] = button10;
            btn[8] = button11; btn[9] = button12; btn[10] = button13; btn[11] = button14;
            btn[12] = button15; btn[13] = button16; btn[14] = button17; btn[15] = button18;
            btn[16] = button19; btn[17] = button20; btn[18] = button21; btn[19] = button22;
            btn[20] = button23; btn[21] = button24; btn[22] = button25; btn[23] = button26;
            for (int i = 0; i < 24; i++)
            {
                btn[i].Text = "";   //空白字元//不能使用
                btn[i].Visible = false; //隱藏btn
            }
            for (int i = 0; i < 24; i++)
            {
                button_number[i] = 0;
            }
            sec = 3;   //設剩餘秒數為3
            label1.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            timer1.Enabled = false;	 // 暫停計時器
            timer1.Interval = 1000;
        }

        private void generate_number()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int a = rnd.Next(1, 4);
            number = 1;
            for (int i = 0; i < a; i++)
            {
                number *= 2; 
            }
            label2.Text = "當前數字: " + number.ToString();
            if (mode == 0)
            {
                sec = 3;
                timer1.Enabled = true;
            }
          
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (mode == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        number = 2;
                        label2.Text = "當前數字: " + number.ToString();
                        break;
                    case Keys.S:
                        number = 4;
                        label2.Text = "當前數字: " + number.ToString();
                        break;
                    case Keys.D:
                        number = 8;
                        label2.Text = "當前數字: " + number.ToString();
                        break;
                    default:
                        break;
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Q:
                    game(1);
                    break;
                case Keys.W:
                    game(2);
                    break;
                case Keys.E:
                    game(3);
                    break;
                case Keys.R:
                    game(4);
                    break;
                default:
                    break;
            }
        }
        private void game(int column)
        {
            int i = column - 1;
            while(button_number[i] > 0 && i < 24)
            {
                i += 4;
            }
            button_number[i] = number;
            vertical_merge(ref i);
            horizon_merge(i);
            for (int k = 0; k < 24; k++)
            {
                if (button_number[k] > 0)
                {
                    btn[k].Enabled = true;
                    btn[k].Text = button_number[k].ToString();
                    btn[k].Visible = true;
                }
                else
                {
                    btn[k].Visible = false;
                }
            }
            if (button_number[20] > 0 || button_number[21] > 0 || button_number[22] > 0 || button_number[23] > 0)
            {
                result = MessageBox.Show("遊戲結束!!!\n你的分數: " + score.ToString(),"",MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            generate_number();
        }
        private void vertical_merge(ref int position)
        {
            if (position > 3 && button_number[position] == button_number[position-4])
            {
                button_number[position - 4] = button_number[position] + button_number[position - 4];
                button_number[position] = 0;
                position -= 4;
                vertical_merge(ref position);
            }
        }
        private void horizon_merge(int position)
        {
            if (position % 4 == 0)
            {
                if (button_number[position] == button_number[position+1] && button_number[position] == button_number[position+2] && button_number[position] == button_number[position + 3])
                {
                    score += button_number[position] * button_number[position];
                    button_number[position] = 0;
                    put(position);
                    button_number[position + 1] = 0;
                    put(position + 1);
                    button_number[position + 2] = 0;
                    put(position + 2);
                    button_number[position + 3] = 0;
                    put(position + 3);
                    label1.Text = "你的分數: " + score.ToString();
                }
            }
            if (position % 4 == 1)
            {
                if (button_number[position] == button_number[position + 1] && button_number[position] == button_number[position + 2] && button_number[position] == button_number[position - 1])
                {
                    score += button_number[position] * button_number[position];
                    button_number[position] = 0;
                    put(position);
                    button_number[position + 1] = 0;
                    put(position + 1);
                    button_number[position + 2] = 0;
                    put(position + 2);
                    button_number[position - 1] = 0;
                    put(position - 1);
                    label1.Text = "你的分數: " + score.ToString();
                }
            }
            if (position % 4 == 2)
            {
                if (button_number[position] == button_number[position + 1] && button_number[position] == button_number[position - 1] && button_number[position] == button_number[position - 2])
                {
                    score += button_number[position] * button_number[position];
                    button_number[position] = 0;
                    put(position);
                    button_number[position + 1] = 0;
                    put(position + 1);
                    button_number[position - 1] = 0;
                    put(position - 1);
                    button_number[position - 2] = 0;
                    put(position - 2);
                    label1.Text = "你的分數: " + score.ToString();
                }
            }
            if (position % 4 == 3)
            {
                if (button_number[position] == button_number[position - 1] && button_number[position] == button_number[position - 2] && button_number[position] == button_number[position - 3])
                {
                    score += button_number[position] * button_number[position];
                    button_number[position] = 0;
                    put(position);
                    button_number[position - 1] = 0;
                    put(position - 1);
                    button_number[position - 2] = 0;
                    put(position - 2);
                    button_number[position - 3] = 0;
                    put(position - 3);
                    label1.Text = "你的分數: " + score.ToString();
                }
            }
        }
        private void put(int position)
        {
            int check = position;
            while(check < 24 && button_number[check] == 0 )
            {
                check += 4;
            }
            if (check < 24 && button_number[check] > 0)
            {
                button_number[position] = button_number[check];
                button_number[check] = 0;
                position = check;
                put(position);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = "倒數計時: " + (sec -= 1).ToString();
            if (sec <= 0)
            {
                timer1.Enabled = false;
                game(2);
            }
        }
    }
}
