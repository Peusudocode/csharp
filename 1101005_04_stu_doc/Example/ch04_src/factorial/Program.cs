using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        private static int Factorial(int tno)
        {
            if (tno == 1)
                return 1;
            else
                return tno * Factorial(tno - 1);
        }
        static void Main(string[] args)
        {
            int no;
            Console.Write("請輸入欲求的階乘值(1-10) : ");
            no = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1} ", no, Factorial(no));
            Console.Read();
        }
    }
}
