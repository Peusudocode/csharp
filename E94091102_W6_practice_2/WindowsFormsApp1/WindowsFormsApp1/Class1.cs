using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Class1
    {
        public int Size; // 字體大小
        public FontFamily Family; // 字型
        public FontStyle Style; // 風格(粗體、斜體)
        public ContentAlignment Alignment; // 字的位置(左中右)
        public int Y_Location = 12; //字的位置(上下)
        public void ChangeLabel(System.Windows.Forms.Label label, )
        {

        } // 將label改變字體與位置   
        public void ChangeAlignment(int type)
        {

        }
        // 改變 ContentAlignment
        public void ChangeFamily(string newFamily)
        {

        }// 改變 FontFamily
        public void ChangeStyle(bool bold, bool italic)
        {

        }// 改變 FontStyle

    }
}
