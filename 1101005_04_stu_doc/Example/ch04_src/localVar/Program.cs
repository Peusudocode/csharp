using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            for (n = 0; n < 6; n++)
            {
                Console.WriteLine(" n = {0} ", n);
            }
            Console.WriteLine(" n = {0} ", n);
            Console.Read();
        }
    }
}
