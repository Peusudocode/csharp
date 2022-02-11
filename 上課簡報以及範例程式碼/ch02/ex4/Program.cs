using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex4
{
    class Program
    {
        struct Student
        {
            public String Id, Name;
            public int Score;
        }
        static void Main(string[] args)
        {
            Student Peter, Mary;
            Console.WriteLine("請輸入第 1 位學生的資料：");
            Console.Write("學號：");
            Peter.Id = Console.ReadLine();
            Console.Write("姓名：");
            Peter.Name = Console.ReadLine();
            Console.Write("分數：");
            Peter.Score = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入第 2位學生的資料：");
            Console.Write("學號：");
            Mary.Id = Console.ReadLine();
            Console.Write("姓名：");
            Mary.Name = Console.ReadLine();
            Console.Write("分數：");
            Mary.Score = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine ("輸入資料如下...");

            Console.WriteLine("第 1 位學生資料-->學號：{0}, 姓名：{1}, 成績{2}", Peter.Id, Peter.Name, Peter.Score.ToString());
            Console.WriteLine("第 2 位學生資料-->學號：{0}, 姓名：{1}, 成績{2}", Mary.Id, Mary.Name, Mary.Score.ToString());

            Console.ReadLine();
        }
    }
}
