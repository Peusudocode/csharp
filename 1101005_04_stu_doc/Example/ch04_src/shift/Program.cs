using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shift
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "";
            int[] ary = new int[] { 111, 222, 333, 444, 555, 666 }; //宣告建立和設定陣列初值 //222, 333, 444, 555, 666 ,111
            // 原始陣列
            Console.Write(" 原始陣列 : ");
            foreach (int num in ary)
                str1 += num.ToString() + "  ";  	// 字串合併
            Console.WriteLine("{0}", str1);
            // 陣列左移     
            int temp;
            temp = ary[0];                  		// 將第零個陣列元素複製到temp變數   111
            for (int i = 0; i <= ary.Length - 2; i++)
                ary[i] = ary[i + 1];             // 將後面的陣列元素往前移動一個陣列元素
            ary[ary.Length - 1] = temp;         	// 將第零個陣列元素移到最後一個陣列元素
            str1 = "";
            Console.Write(" 陣列左移 : ");
            foreach (int num in ary)          		// 依序讀取陣列的內容
                str1 += num.ToString() + "  "; 	// 將讀出的陣列元素做字串合併
            Console.WriteLine("{0}", str1);    		// 顯示陣列左移後的結果
            // 陣列右移
            Console.Write(" 陣列右移 : ");
            temp = ary[ary.Length - 1];         	// 將最後一個陣列元素複製到temp變數   xxx,222, 333, 444, 555, 666 
            for (int i = ary.Length - 1; i >= 1; i--)  // i  = 6-1 = 5
                ary[i] = ary[i - 1];       //  5- 1 = 4 ary[4] = 666 // 將前面的陣列元素往後移動一個陣列元素
            ary[0] = temp;              // 將最後一個陣列元素移到最前面第0個陣列元素
            str1 = "";
            foreach (int num in ary)
                str1 += num.ToString() + "  ";  	// 將讀出的陣列元素字串合併
            Console.WriteLine("{0}", str1);    		// 顯示陣列右移後的結果
            Console.Read();
        }
    }
}
