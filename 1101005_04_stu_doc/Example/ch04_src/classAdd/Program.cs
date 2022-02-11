using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. 請輸入一個正整數 : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = Class1.Add(num1);   // 呼叫不同類別的Add靜態方法
            Console.WriteLine("2. 相加結果 : {0} ", num2);
            Console.Read();
        }
    }
    public class Class1       // 建立Class1類別
    {
        public static int Add(int n1)  // Class1類別內的Add方法
        {
            int sum;
            sum = n1 + 20;
            return sum;      // 傳回值
        }
    }
}
