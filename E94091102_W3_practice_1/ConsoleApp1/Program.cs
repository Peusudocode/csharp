using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.Write("1月1號星期幾(1~7):");
            string get = Console.ReadLine();
            try
            {
                a = int.Parse(get);
            }
            catch(FormatException)
            {
                Console.WriteLine("請輸入範圍內整數");
            }
            if (a < 1 || a > 7)
            {
                Console.WriteLine("超出範圍");
                System.Environment.Exit(0);
            }
            Console.Write("從幾月開始(1~12):");
            get = Console.ReadLine();
            try
            {
                b = int.Parse(get);
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入範圍內整數");
            }
            if (b < 1 || b > 12)
            {
                Console.WriteLine("超出範圍");
                System.Environment.Exit(0);
            }
            string[] month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] day = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] abc = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            for (int j = b; j <= 12; j++)
            {
                int totaldays = 0;
                for (int i = 0; i < j - 1; i++)
                    totaldays += days[i];
                int week = totaldays % 7;
                int c = (week + a) % 7;
                Console.WriteLine("{0}", month[j-1]);
                for (int k = 0; k < 7; k++)
                {
                    Console.Write("{0} ", day[k]);
                };
                Console.WriteLine();
                for (int d = 1; d < c; d++)
                {
                    Console.Write("    ");
                    continue;
                }
               
                for (int e = 0; e < days[j-1]; e++)
                {
                    if (((e + c - 1) % 7 == 0) && (e !=0))
                    {
                        Console.WriteLine();
                    }
                    Console.Write("{0,3}", abc[e]);
                    Console.Write(" ");
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine();
            };
            Console.ReadKey();

        }
    }
}
