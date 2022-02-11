using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objAddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();          // 建立Class1類別的物件
            Console.Write("1. 請輸入一個正整數 : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = obj.Add(num1);   // 呼叫obj物件的Add方法
            Console.WriteLine("2. 相加結果 : {0} ", num2);
            Console.Read();
        }
    }
    // -----------------------------------------------------------------------------------------
    public class Class1        // 建立Class1類別
    {
        public int Add(int n1)  //未加ststic無法直接呼叫必須先建物件實體才能呼叫
        {
            int sum;
            sum = n1 + 20;
            return sum;       // 傳回值
        }
    }
}
