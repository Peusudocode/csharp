using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicAry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data;	         // 陣列名稱
            string str1 = "";
            int size;           // 陣列大小
            Console.Write(" 輸入陣列大小 : ");
            size = int.Parse(Console.ReadLine());
            if (size >= 1 && size <= 9)
            {
                data = new int[size];
                for (int i = 0; i < data.Length; i++)
                    data[i] = 111 * (i + 1);
                foreach (int num in data)
                    str1 += num.ToString() + "\n";
                Console.WriteLine("{0}", str1);
            }
            else
                Console.WriteLine(" 陣列大小範圍限1-9 ! …");
            Console.Read();
        }
    }
}
