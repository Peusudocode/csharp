using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passValue
{
    class Program
    {
        private static void passValue(int x, int y)
        {
            x = x + 5;
            y = y + 10;
            Console.WriteLine(" 2. 呼叫中 : x =  {0}  y = {1}", x, y);
        }
        // -----------------------------------------------------------------
        static void Main(string[] args)
        {
            int a, b;
            a = 1;
            b = 10;
            Console.WriteLine("  =====  傳值呼叫  === ");
            Console.WriteLine(" 1. 呼叫前 : a =  {0}  b = {1}  ", a, b);
            passValue(a, b);
            Console.WriteLine(" 3. 呼叫後 : a =  {0}  b = {1}  ", a, b);
            Console.Read();
        }
    }
}
