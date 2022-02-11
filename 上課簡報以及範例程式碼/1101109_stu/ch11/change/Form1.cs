using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CheckBox[] chkKind = new CheckBox[7];//宣告核取方塊控制項陣列
        Label[] lblNum = new Label[7];       //宣告標籤控制項陣列

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMoney.Text = "1689";  //預設兌換金額為1689元
            chkKind[0] = chk1000; //指定核取方塊控制項陣列元素 
            chkKind[1] = chk500; chkKind[2] = chk100; chkKind[3] = chk50;
            chkKind[4] = chk10; chkKind[5] = chk5; chkKind[6] = chk1;
            lblNum[0] = lbl1000;  //指定標籤控制項陣列元素
            lblNum[1] = lbl500; lblNum[2] = lbl100; lblNum[3] = lbl50;
            lblNum[4] = lbl10; lblNum[5] = lbl5; lblNum[6] = lbl1;
            for (int i = 0; i <= 6; i++)
            {
                lblNum[i].Text = "0";  //設定標籤控制項陣列元素Text初值為0
                chkKind[i].Checked = true;  //勾選核取方塊控制項陣列元素
            }
            chk1.Enabled = false; //設1元核取方塊不能使用
        }

        private void mnuChange_Click(object sender, EventArgs e)
        {
            double money;
            try
            {
                money = double.Parse(txtMoney.Text);//讀取兌換金額
                money = Math.Floor(money); //小數捨棄取到整數
                int[] kind = { 1000, 500, 100, 50, 10, 5, 1 };//kind陣列中存放兌換面額
                int num; //紀錄各面額的兌換個數
                for (int i = 0; i <= 6; i++)
                {
                    num = 0;  //設兌換個數為0
                    if (chkKind[i].Checked == true)//若有勾選該面額
                    {
                        while (money - kind[i] >= 0) //當兌換餘額-兌換面額>=0
                        {
                            num++;  //兌換個數+1
                            money -= kind[i];//-兌換面額=兌換餘額
                        }
                    }
                    lblNum[i].Text = num.ToString();//顯示該面額的兌換個數
                }
            }
            catch
            {
                MessageBox.Show("兌換金額請輸入數值！", "錯誤", MessageBoxButtons.OK);
                txtMoney.Text = "1689";
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
