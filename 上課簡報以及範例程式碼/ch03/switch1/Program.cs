using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.Write("=== 請輸入現在的月份: ");
            month = Console.ReadLine();  // 輸入月份
            switch (month)
            {
                case "3":      // 判斷month是否為"3" ~ "5"
                case "4":
                case "5":
                    Console.WriteLine(" \n ... 現在是春天 ...");
                    break;
                case "6":    // 判斷month是否為"6" ~ "8"
                case "7":
                case "8":
                    Console.WriteLine(" \n ... 現在是夏天 ...");
                    break;
                case "9":     // 判斷month是否為"9" ~ "11"
                case "10":
                case "11":
                    Console.WriteLine(" \n ... 現在是秋天 ...");
                    break;
                case "12":    // 判斷month是否為"12"、"1"、"2"
                case "1":
                case "2":
                    Console.WriteLine(" \n ... 現在是冬天 ...");
                    break;
                default:	  // month為其他值
                    Console.WriteLine(" \n ... 輸入值超出範圍 ....");
                    break;
            }
            Console.Read();
        }
    }
}
