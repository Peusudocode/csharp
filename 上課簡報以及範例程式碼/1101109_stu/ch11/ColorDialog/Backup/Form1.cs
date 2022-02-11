using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs_FontColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.AutoSize = true;
            lblShow.Text = "VC# 2008 是學習程式設計的最佳選擇";
            myFontDialog.ShowColor = true;
        }

        private void btnFore_Click(object sender, EventArgs e)
        {
            if (myColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblShow.ForeColor = myColorDialog.Color;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (myColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblShow.BackColor = myColorDialog.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (myFontDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblShow.Font = myFontDialog.Font;
                lblShow.ForeColor = myFontDialog.Color;
            }
        }
    }
}
