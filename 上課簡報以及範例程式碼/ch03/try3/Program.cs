using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, p;
            i = 5;
            k = 0;
            try
            {
                p = i / k;  // 將可能發生例外的程式碼置於try區塊
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("例外訊息：{0}", ex.Message);
                Console.WriteLine("發生例外的函式：{0}", ex.StackTrace);
                Console.WriteLine("發生例外的物件：{0}", ex.Source);
                Console.WriteLine("發生例外的物件型別：{0}", ex.GetType());
                Console.WriteLine("發生例外的文字說明：{0}", ex.ToString());
            }
            finally   // 無論是否發生例外，皆會執行finally區塊中的程式碼
            {
                Console.WriteLine(".... 結束程式執行!! ....");
            }
            Console.Read();
        }
    }
}
