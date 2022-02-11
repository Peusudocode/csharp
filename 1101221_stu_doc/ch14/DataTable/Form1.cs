using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO:  這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.書目BindingSource.EndEdit();
            this.書目TableAdapter.Update(this.database1DataSet.書目);
        }
    }
}
