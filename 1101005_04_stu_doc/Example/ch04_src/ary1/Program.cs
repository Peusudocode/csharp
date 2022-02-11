using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ary1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tAry = new int[] { 10, 20, 30, 40, 50 };
            for (int k = 0; k <= tAry.Length - 1; k++)
                Console.Write(" tAry[{0}]={1}  ", k, tAry[k]);  //k =0 , tAry[0] = 10
            Console.Read();
        }
    }
}
