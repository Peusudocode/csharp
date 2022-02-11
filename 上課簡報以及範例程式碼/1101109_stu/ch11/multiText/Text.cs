using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiText
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText != "")//若選取的字串不等於空字串
                txtInput.Copy();//複製選取的文字到剪貼簿
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtInput.Paste();//將剪貼簿內文字複製到游標處
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText != "")//若選取的字串不等於空字串
                txtInput.Cut();//剪下選取的文字並複製到剪貼簿
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();//關閉目前的表單
        }

        private void Text_Load(object sender, EventArgs e)
        {

        }
    }
}
