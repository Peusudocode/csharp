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
            Monster mon = new Monster();

            mon.Attack(vi);

            MessageBox.Show("Villager-->" + vi.GetHP());

            Monster mon2 = new Monster();
            mon.Attack(mon2);
            MessageBox.Show("Monster-->" + mon2.GetHP());
        }
    }
}
