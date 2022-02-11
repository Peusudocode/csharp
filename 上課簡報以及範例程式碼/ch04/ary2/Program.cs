using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ary2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] msg = new string[4] { "Time", "is", "money", "." };
            foreach (string word in msg)
                Console.Write(" {0} ", word);
            Console.Read();    
        }
    }
}
