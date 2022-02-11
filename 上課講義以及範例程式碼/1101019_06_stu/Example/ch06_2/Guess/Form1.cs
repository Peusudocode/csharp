using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int largeN, smallN, ansN, guessN;

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtGuess, "請輸入一個二位數數值！");
            largeN = 100;
            smallN = 10;
            Random rnd = new Random();
            ansN = rnd.Next(smallN, largeN);
            getStart();   // 使輸入數字的文字方塊啟始化
        }

        private void getStart()
        {
            lblLarge.Text = largeN.ToString();
            lblSmall.Text = smallN.ToString();
            txtGuess.Text = "";
            txtGuess.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                guessN = int.Parse(txtGuess.Text);
            }
            catch
            {
                MessageBox.Show("請輸入一個二位數數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                getStart();         //呼叫自定函式,設定畫面最新狀態
                return;
            }

            if (guessN == ansN)
                MessageBox.Show("恭喜你答對了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                if (guessN > largeN || guessN < smallN)
                {
                    String msg = "請輸入介於 " + smallN + " 與 " + largeN + " 之間的數值";
                    MessageBox.Show(msg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (guessN > ansN)
                {
                    MessageBox.Show("輸入小一點的數", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    largeN = guessN;
                }
                else if (guessN < ansN)
                {
                    MessageBox.Show("輸入大一點的數", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    smallN = guessN;
                }
                getStart();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
