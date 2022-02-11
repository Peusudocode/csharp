using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //使用 messagebox
using System.Threading.Tasks;

namespace Constructor_test
{
    class Student
    {
        //Property==> The property of class is that Property uses variables to record the content.
        public int StudentID;
        public string Name;
        public int Grade;
   
        public Student() // does not output any type, same name as the class
        {
            MessageBox.Show("This is a test!!");
        }




        public void Upgrade()  ///void does not return value and does not need to input data
        {
            Grade++;
        }



    }

}
