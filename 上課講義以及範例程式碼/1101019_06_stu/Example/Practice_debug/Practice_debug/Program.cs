using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            int diva = 0, divb = 0, res = 0, cho = 1;

            while (true)
            {
                Console.WriteLine("被除數 : ");
                diva = int.Parse(Console.ReadLine());
                Console.WriteLine("除數 : ");
                divb = int.Parse(Console.ReadLine());

                res = divb / diva;

                Console.WriteLine("相除後答案是 : {0}", res);

                Console.WriteLine("\n是否離開程式: 輸入 0 離開");
                cho = int.Parse(Console.ReadLine());

                if (cho == 1)
                    break;
            }


        }
    }
}
