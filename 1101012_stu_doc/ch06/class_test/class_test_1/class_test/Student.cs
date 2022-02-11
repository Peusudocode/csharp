using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test
{
    class Student
    {
     	//Property==> The property of class is that Property uses variables to record the content.
        public int StudentID;
        public string Name;
        public int Grade;

        // Method==>>class can do ,  output type, string method name (input type and name)
        public string Say()
        {
            return "My name is " + Name + " , I am a " + Grade + " grade student";
        }
    }
}
