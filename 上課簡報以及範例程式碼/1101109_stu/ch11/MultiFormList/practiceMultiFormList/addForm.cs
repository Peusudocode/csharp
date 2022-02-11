using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceMultiFormList
{
    public partial class addForm : Form
    {
        public string name;
        public addForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(this.txtName.Text == "")
            {
                MessageBox.Show("姓名不應為空!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.name = this.txtName.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.name = "";
            this.Close();
        }
    }
}
