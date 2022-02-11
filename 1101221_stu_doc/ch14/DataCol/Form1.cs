using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 通訊錄BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.通訊錄BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.friendDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'friendDataSet.通訊錄' 資料表。您可以視需要進行移動或移除。
            this.通訊錄TableAdapter.Fill(this.friendDataSet.通訊錄);
        }
    }
}
