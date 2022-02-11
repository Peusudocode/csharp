using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranObj = new Random();  // 建立名稱為ranObj亂數物件實體
            int ranNo;
            for (int i = 1; i <= 5; i++)
            {
                ranNo = ranObj.Next(10, 51);
                Console.WriteLine("第{0}個亂數 : {1}", i, ranNo);
            }
            Console.Read();
        }
    }
}
