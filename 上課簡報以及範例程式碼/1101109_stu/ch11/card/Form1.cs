using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // 指定列印相關控制項的資料來源為printDocument1
            printPreviewDialog1.Document = printDocument1;
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            fontDialog1.ShowColor = true;   //可以設定字型顏色
            txtCom.Text = "○○○○股份有限公司 ○○○○○○○○ INC.";
            txtTitle.Text = "協理";
            txtName.Text = "張OO";
            txtAddress.Multiline = true;    //多行
            txtAddress.Text = "○○○ ○○市○○區○○路○○號\r\nTEL：(00)0000-0000";
            picLogo.Image = Image.FromFile("logo.jpg");    //載入圖檔
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {   //設定字型對話方塊設定的字型和目前作用中控制項相同
            fontDialog1.Font = this.ActiveControl.Font;
            //當使用者在字型對話方塊中按確定鈕時
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   //設定目前作用中控制項和字型對話方塊設定的字型相同
                this.ActiveControl.Font = fontDialog1.Font;
                this.ActiveControl.ForeColor = fontDialog1.Color;
            }
        }

        private void mnuSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();    // 顯示列印格式對話方塊
            // 設定printDocument1的列印格式等於列印格式對話方塊的設定
            printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void mnuPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();   // 顯示預覽列印對話方塊
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {   // 若在列印對話方塊按確定鈕
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();    // 執行Print方法
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;  // 宣告繪圖物件g
            Single x = printDocument1.DefaultPageSettings.Margins.Left;  // 讀取左邊界
            Single y = printDocument1.DefaultPageSettings.Margins.Top;  // 讀取上邊界
            // 字型樣示f 紀錄txtCom中的字型樣式
            Font f = new Font(txtCom.Font.Name, txtCom.Font.Size, txtCom.Font.Style);
            // 宣告筆刷物件顏色為txtCom的前景色
            //https://docs.microsoft.com/zh-tw/dotnet/api/system.drawing.solidbrush?view=dotnet-plat-ext-3.1
            SolidBrush b = new SolidBrush(txtCom.ForeColor);
            g.DrawString(txtCom.Text, f, b, txtCom.Left + x, txtCom.Top + y);//印txtCom.Text
            f = new Font(txtTitle.Font.Name, txtTitle.Font.Size, txtTitle.Font.Style);
            b = new SolidBrush(txtTitle.ForeColor);
            g.DrawString(txtTitle.Text, f, b, txtTitle.Left + x, txtTitle.Top + y);//印txtTitle.Text
            f = new Font(txtName.Font.Name, txtName.Font.Size, txtName.Font.Style);
            b = new SolidBrush(txtName.ForeColor);
            g.DrawString(txtName.Text, f, b, txtName.Left + x, txtName.Top + y);//印txtName.Text
            f = new Font(txtAddress.Font.Name, txtAddress.Font.Size, txtAddress.Font.Style);
            b = new SolidBrush(txtAddress.ForeColor);
            g.DrawString(txtAddress.Text, f, b, txtAddress.Left + x, txtAddress.Top + y);//印txtAddress.Text
            //用DrawImage方法印出picLogo圖檔
            g.DrawImage(picLogo.Image, picLogo.Left + x, picLogo.Top + y, picLogo.Width, picLogo.Height);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
