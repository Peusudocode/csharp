using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_test
{
    class Student
    {
        
        public int StudentID;
        public string Name;
        public int Grade;

        // Overloading 
        public Student(int studentID, string name) 
        {
           StudentID = studentID;
            Name = name;
            Grade = 1;
        }
        public Student(int studentID, string name, int grade) 
        {
            StudentID = studentID;
            Name = name;
            Grade = grade;
        }

        public string Say()
        {
            return "My name is " + Name + " , I am a " + Grade + " grade student";
        }


    }

}
