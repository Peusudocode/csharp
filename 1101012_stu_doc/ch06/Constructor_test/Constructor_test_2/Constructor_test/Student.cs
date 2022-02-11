using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_test
{
    class Student
    {
        //Property==> The property of class is that Property uses variables to record the content.
        public int StudentID;
        public string Name;
        public int Grade;
        public Student() //does not output any type, same name as the class
        {
            Grade = 1;
        }

        public string Say()
        {
            return "My name is " + Name + " , I am a " + Grade + " grade student";
        }




    }

}
