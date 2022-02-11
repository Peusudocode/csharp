using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.書目' table. You can move, or remove it, as needed.
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: This line of code loads data into the 'database1DataSet.出版者' table. You can move, or remove it, as needed.
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);

        }
    }
}
