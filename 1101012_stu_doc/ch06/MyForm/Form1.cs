using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "Activated 事件";
            this.Location = new Point(250, 250);
            this.Size = new Size(300, 200);
            this.BackColor = Color.Green;
        }

         private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Click 事件";
            this.BackColor = Color.White;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = "Form1_Resize";
            this.BackColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
