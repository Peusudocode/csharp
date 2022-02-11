using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Villager vi = new Villager();
            //      MessageBox.Show("-->"+vi.Talk());
            MessageBox.Show("vi-->" + vi.GetHP());

            Monster mon = new Monster();

            MessageBox.Show("mon-->" + mon.GetHP());

            vi.Injured(mon.Attack());
            MessageBox.Show("vi2-->" + vi.GetHP());
        }
    }
}
