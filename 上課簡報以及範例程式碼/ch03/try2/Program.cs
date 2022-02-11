using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try2
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
                p = i / k;  			// 將可能發生例外的程式碼置於try區塊
            }
            catch(DivideByZeroException ex)    	//當發生的例外符合DivideByZeroException時會執行此處
            {
                Console.WriteLine(ex.Message);	// Message可以用來顯示目前的例外訊息
            }
            catch (Exception ex)  	// 當發生的例外符合Exception時會執行此處
            {
                Console.WriteLine("發生例外");
            }
            finally  				// 無論是否發生例外皆會執行finally區塊
            {
                Console.WriteLine(".... 結束程式執行!! ....");
            }
            Console.Read();
        }
    }
}
