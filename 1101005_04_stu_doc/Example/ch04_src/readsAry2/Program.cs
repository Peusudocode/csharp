using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readsAry2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "錢一文", "孫二娘", "張三豐", "李四維", "王五行" };
            int[,] score = { { 80, 75, 60 }, { 65, 67, 62 }, { 100, 93, 91 }, { 98, 25, 50 }, { 83, 82, 87 } };
            int no;
            Console.Write(" 輸入座號(1-5)：");
            no = int.Parse(Console.ReadLine());
            if (no >= 1 && no <= 5)
            {
                Console.WriteLine("1. 姓名 : {0} ", name[no - 1]);
                Console.WriteLine("2. 國文 : {0} ", score[no - 1, 0]);
                Console.WriteLine("3. 英文 : {0} ", score[no - 1, 1]);
                Console.WriteLine("4. 數學 : {0} ", score[no - 1, 2]);
            }
            else
                Console.WriteLine(" ... 空號 ... ");
            Console.Read();
        }
    }
}
