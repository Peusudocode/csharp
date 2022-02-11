using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member
{
    class Program
    {
        private static int n = 5;   // 成員變數(欄位變數)
        // -------------------------------------------
        private static void Add()
        {
            n += 5;    // n=15+5=20
            Console.WriteLine(" n = {0} ", n);   // 顯示n=20
        }
        // -------------------------------------------
        static void Main(string[] args)
        {
            n += 10;                        // n=5+10=15
            Console.WriteLine(" n = {0} ", n);  // 顯示n=15
            Add();
            n += 20;                       // n=20+20=40
            Console.WriteLine(" n = {0} ", n);  // 顯示n=40
            Console.Read();
        }
    }
}
