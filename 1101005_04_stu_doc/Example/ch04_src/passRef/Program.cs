using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passRef
{
    class Program
    {
        private static void passRef(float a, float b, ref float c)
        {
            c = a + b;
        }
        // ---------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            float sum = 0;
            Console.Write("1. 請輸入被加數 : ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("2. 請輸入 加 數 : ");
            float num2 = float.Parse(Console.ReadLine());
            passRef(num1, num2, ref sum);
            Console.WriteLine("3. 相加結果 : {0} + {1} = {2} ", num1, num2, sum);
            Console.Read();
        }
    }
}
