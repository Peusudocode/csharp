using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseif1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("請輸入第一個整數(num1) : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第二個整數(num2) : ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)  // 判斷num1是否等於num2
               Console.WriteLine("{0} = {1}", num1, num2);
            else if (num1 > num2)  // 判斷num1是否大於num2
               Console.WriteLine("{0} > {1}", num1, num2);
            else                              // 判斷num1是否小於num2
               Console.WriteLine("{0} < {1}", num1, num2);
            Console.Read();
        }
    }
}
