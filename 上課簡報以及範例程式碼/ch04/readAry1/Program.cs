using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readAry1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];  // 宣告並建立name為成員字串陣列
            name[0] = "AA"; name[1] = "BB"; name[2] = "CC";
            name[3] = "DD"; name[4] = "EE";
            int no;
            Console.Write(" 1. Input seat number (1-5)：");
            no = int.Parse(Console.ReadLine());
            if (no >= 1 && no <= 5)
                Console.WriteLine(" 2. Student name  : {0} ", name[no - 1]);
            else
                Console.WriteLine(" ... This is an empty number ... ");
            Console.Read();
        }
    }
}
