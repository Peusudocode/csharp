using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forsample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)   		// 外層迴圈
            {
                for (int k = 1; k <= i; k++)		// 內層迴圈
                {
                    Console.Write("{0} ", k);
                }
                Console.WriteLine();         // 將游標下移一列
            }
            Console.Read();
        }
    }
}
