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
        Button[] board = new Button[361];
        int start_game = 0;
        Character P1 = new Character();
        Character P2 = new Character();
        int round = 0; // 回合(偶數:P1，奇數:P2)
        int piece = 0; // 旗子( 0:普通，1:橫向，2:縱向，3:覆蓋)
        DialogResult result;
        private void Form1_Load(object sender, EventArgs e)
        {
            button9.Visible = false;
            button8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (start_game == 0)
            {
                label2.Text = "P1:戰士";
                P1.numB = 0;
                P1.numC = 0;
                P1.numD = 5;
                P1.color = Color.DeepSkyBlue;
            }
            else if (start_game == 1)
            {
                piece = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (start_game == 1)
            {
                P2.numD -= 1;
                piece = 3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            start_game = 1;
            button7.Visible = false; 
            button1.Text = "普通棋子"; // P2旗子button
            button2.Text = "橫向棋子:" + P2.numB.ToString() + "顆";
            button3.Text = "縱向棋子:" + P2.numC.ToString() + "顆";
            button8.Text = "覆蓋棋子:" + P2.numD.ToString() + "顆";
            button8.Visible = true; 

            button4.Text = "普通棋子"; // P1旗子button
            button5.Text = "橫向棋子:" + P1.numB.ToString() + "顆";
            button6.Text = "縱向棋子:" + P1.numC.ToString() + "顆";
            button9.Text = "覆蓋棋子:" + P1.numD.ToString() + "顆";
            button9.Visible = true;
            int x = 0, y = 0;
            for (int i = 0; i < 361; i++)
            {
                if (x % 19 == 0)
                {
                    y++;
                    x = 0;
                }
                int index = i;
                board[i] = new Button();
                board[i].SetBounds((150 + 21 * x), (50 + 21 * y), 21, 21);//(starting point X, starting point Y, width, heighth)
                board[i].BackColor = Color.Gray;
                //card[i].Click += (sender, ex) => this.card_click(index);
                board[i].Click += btn_Click;
                Controls.Add(board[i]);
                x++;
            }
            game();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;   //將sender轉型為按鈕物件btnClick
            int Index = Array.IndexOf(board, btnClick);
            if (piece == 0)
            {
                if (btnClick.BackColor == Color.Gray)
                {
                    if (round % 2 == 0)
                    {
                        btnClick.BackColor = P1.color;
                    }
                    else if (round % 2 == 1)
                    {
                        btnClick.BackColor = P2.color;
                    }
                }
            }
            else if (piece == 1)
            {
                if (btnClick.BackColor == Color.Gray)
                {
                    if (round % 2 == 0)
                    {
                        btnClick.BackColor = P1.color;
                    }
                    else if (round % 2 == 1)
                    {
                        btnClick.BackColor = P2.color;
                    }
                }
                if (Index % 19 != 18)
                {
                    if (board[Index + 1].BackColor == Color.Gray)
                    {
                        if (round % 2 == 0)
                        {
                            board[Index + 1].BackColor = P1.color;
                        }
                        else if (round % 2 == 1)
                        {
                            board[Index + 1].BackColor = P2.color;
                        }
                    }
                }
            }
            else if (piece == 2)
            {
                if (btnClick.BackColor == Color.Gray)
                {
                    if (round % 2 == 0)
                    {
                        btnClick.BackColor = P1.color;
                    }
                    else if (round % 2 == 1)
                    {
                        btnClick.BackColor = P2.color;
                    }
                }
                if (Index < 342)
                {
                    if (board[Index + 19].BackColor == Color.Gray)
                    {
                        if (round % 2 == 0)
                        {
                            board[Index + 19].BackColor = P1.color;
                        }
                        else if (round % 2 == 1)
                        {
                            board[Index + 19].BackColor = P2.color;
                        }
                    }
                }
            }
            if (piece == 3)
            {
                if (round % 2 == 0)
                {
                    btnClick.BackColor = P1.color;
                }
                else if (round % 2 == 1)
                {
                    btnClick.BackColor = P2.color;
                }
            }
            check(Index);
            piece = 0;
            round += 1;
            game();
        }

        private void check(int position)
        {
            int win = 0;
            int check_position = position;
            // 上下檢查
            while (check_position > 18 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position -= 19;
            }
            check_position = position;
            while (check_position < 342 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position += 19;   
            }
            if (win > 5)
            {
                if(round % 2 == 0)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP1獲勝了", "", MessageBoxButtons.OK);
                }
                else if (round % 2 == 1)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP2獲勝了", "", MessageBoxButtons.OK);
                }
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                win = 0;
                check_position = position;
            }
            // 左右檢查
            while (check_position % 19 <= 18 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position += 1;
            }
            check_position = position;
            while (check_position % 19 >= 0 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position -= 1;
            }
            if (win > 5)
            {
                if (round % 2 == 0)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP1獲勝了", "", MessageBoxButtons.OK);
                }
                else if (round % 2 == 1)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP2獲勝了", "", MessageBoxButtons.OK);
                }
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                win = 0;
                check_position = position;
            }
            // 右上左下檢查
            while (check_position >= 0 && check_position < 361 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position -= 18;
                if (check_position % 19 == 18)
                {
                    break;
                }
            }
            check_position = position;
            while (check_position % 19 >= 0 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position += 18;
                if (check_position % 19 == 0)
                {
                    break;
                }
            }
            if (win > 5)
            {
                if (round % 2 == 0)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP1獲勝了", "", MessageBoxButtons.OK);
                }
                else if (round % 2 == 1)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP2獲勝了", "", MessageBoxButtons.OK);
                }
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                win = 0;
                check_position = position;
            }
            // 左上右下檢查
            while (check_position >= 0 && check_position < 361 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position -= 20;
                if (check_position % 19 == 0)
                {
                    break;
                }
            }
            check_position = position;
            while (check_position >= 0 && check_position < 361 && board[check_position].BackColor == board[position].BackColor)
            {
                win += 1;
                check_position += 20;
                if (check_position % 19 == 18)
                {
                    break;
                }
            }
            if (win > 5)
            {
                if (round % 2 == 0)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP1獲勝了", "", MessageBoxButtons.OK);
                }
                else if (round % 2 == 1)
                {
                    result = MessageBox.Show("遊戲結束!!!\nP2獲勝了", "", MessageBoxButtons.OK);
                }
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                win = 0;
                check_position = position;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (start_game == 0)
            {
                label1.Text = "P2:戰士";
                P2.numB = 0;
                P2.numC = 0;
                P2.numD = 6;
                P2.color = Color.Orange;
            }
            else if (start_game == 1)
            {
                piece = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (start_game == 0)
            {
                label1.Text = "P2:法師";
                P2.numB = 1;
                P2.numC = 2;
                P2.numD = 3;
                P2.color = Color.DarkOrange;
            }
            else if ( start_game == 1)
            {
                P2.numB -= 1;
                piece = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (start_game == 0)
            {
                label1.Text = "P2:弓箭手";
                P2.numB = 1;
                P2.numC = 1;
                P2.numD = 4;
                P2.color = Color.OrangeRed;
            }
            else if (start_game == 1)
            {
                P2.numC -= 1;
                piece = 2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (start_game == 0)
            {
                label2.Text = "P1:法師";
                P1.numB = 1;
                P1.numC = 2;
                P1.numD = 2;
                P1.color = Color.DarkBlue;
            }
            else if (start_game == 1)
            {
                P1.numB -= 1;
                piece = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (start_game == 0)
            {
                label2.Text = "P1:弓箭手";
                P1.numB = 1;
                P1.numC = 1;
                P1.numD = 3;
                P1.color = Color.BlueViolet;
            }
            else if (start_game == 1)
            {
                P1.numC -= 1;
                piece = 2;
            }
        }
        private void game()
        {
            button1.Text = "普通棋子"; // P2旗子button
            button2.Text = "橫向棋子:" + P2.numB.ToString() + "顆";
            button3.Text = "縱向棋子:" + P2.numC.ToString() + "顆";
            button8.Text = "覆蓋棋子:" + P2.numD.ToString() + "顆";

            button4.Text = "普通棋子"; // P1旗子button
            button5.Text = "橫向棋子:" + P1.numB.ToString() + "顆";
            button6.Text = "縱向棋子:" + P1.numC.ToString() + "顆";
            button9.Text = "覆蓋棋子:" + P1.numD.ToString() + "顆";
            if (round % 2 == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button8.Enabled = false;
                
                button4.Enabled = true;
                if (P1.numB != 0)
                {
                    button5.Enabled = true;
                }
                else
                {
                    button5.Enabled = false;
                }
                if (P1.numC != 0)
                {
                    button6.Enabled = true;
                }
                else
                {
                    button6.Enabled = false;
                }
                if (P1.numD != 0)
                {
                    button9.Enabled = true;
                }
                else
                {
                    button9.Enabled = false;
                }
            }
            else if (round % 2 == 1)
            {
                button1.Enabled = true;
                if (P2.numB != 0)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                if (P2.numC != 0)
                {
                    button3.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                }
                if (P2.numD != 0)
                {
                    button8.Enabled = true;
                }
                else
                {
                    button8.Enabled = false;
                }

                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (start_game == 1)
            {
                P1.numD -= 1;
                piece = 3;
            }
        }
    }
}
