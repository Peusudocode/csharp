using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkbA.Value = 255; tkbR.Value = 128; //設定各滑動軸初值
            tkbG.Value = 128; tkbB.Value = 128;
        }

        private void tkbA_ValueChanged(object sender, EventArgs e)
        {   //設定lblColor的BackColor屬性值為各捲軸的Value值
            //Color.From.Argb([Alpha.]Red,Green,Blue);
            lblColor.BackColor = Color.FromArgb(tkbA.Value, tkbR.Value, tkbG.Value, tkbB.Value);
  
            lblA.Text = "透明度=" + tkbA.Value.ToString(); //顯示tkbA捲軸的Value值
        }

        private void tkbR_ValueChanged(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromArgb(tkbA.Value, tkbR.Value, tkbG.Value, tkbB.Value); 
            lblR.Text = "紅=" + tkbR.Value.ToString(); //顯示hsbR捲軸的Value值
        }

        private void tkbG_ValueChanged(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromArgb(tkbA.Value, tkbR.Value, tkbG.Value, tkbB.Value); 
            lblG.Text = "綠=" + tkbG.Value.ToString(); //顯示hsbG捲軸的Value值
        }

        private void tkbB_ValueChanged(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromArgb(tkbA.Value, tkbR.Value, tkbG.Value, tkbB.Value); 
            lblB.Text = "藍=" + tkbB.Value.ToString(); //顯示hsbB捲軸的Value值
        }

    }
}
