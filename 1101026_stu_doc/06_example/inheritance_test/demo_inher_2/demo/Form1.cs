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

            //2   vi.Injured(mon.Attack());

            ///2   int a = mon.Attack();
            ///2   a = 50;

            ///2   vi.Injured(a);

            mon.Attack(vi);


            MessageBox.Show("vi2-->" + vi.GetHP());
        }
    }
}
