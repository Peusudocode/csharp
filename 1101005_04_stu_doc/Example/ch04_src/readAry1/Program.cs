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
            name[0] = "錢一文"; name[1] = "孫二娘"; name[2] = "張三豐";
            name[3] = "李四維"; name[4] = "王五金";
            int no;
            Console.Write(" 1. 輸入座號(1-5) ：");
            no = int.Parse(Console.ReadLine());
            if (no >= 1 && no <= 5)
                Console.WriteLine(" 2. 學生姓名 : {0} ", name[no - 1]);
            else
                Console.WriteLine(" ... 這是空號 ... ");
            Console.Read();
        }
    }
}
