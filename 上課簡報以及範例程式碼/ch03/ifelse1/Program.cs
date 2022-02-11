using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse1
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
            // 判斷num1是否等於num2
            if (num1 == num2)
            {
                Console.WriteLine("{0} = {1}", num1, num2);
            }
            else  // num1不等於num2則執行下面程式區段
            {
                if (num1 > num2)  // 判斷num1是否大於num2
                {
                    Console.WriteLine("{0} > {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} < {1}", num1, num2);
                }
            }
            Console.Read();
        }
    }
}
