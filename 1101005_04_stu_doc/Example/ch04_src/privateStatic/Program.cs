using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateStatic
{
    class Program
    {
        private static int Add(int n1)  // 定義Add為私有靜態方法，傳回整數值
        {
            int sum;            // 宣告區域變數
            sum = n1 + 20;
            return sum;          // 傳回值
        }
        static void Main(string[] args)
        {
            Console.Write("1. 請輸入一個正整數 : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = Add(num1);    // 呼叫上面同類別定義的Add私有靜態方法
            Console.WriteLine("2. 相加結果 : {0} ", num2);
            Console.Read();
        }
    }
}
