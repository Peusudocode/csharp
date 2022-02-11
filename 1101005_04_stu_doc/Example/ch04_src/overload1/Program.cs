using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload1
{
    class Program
    {
        private static double Area(double r)
        {
            return r * r * 3.14;
        }
        // --------------------------------------------------------------------------------------------
        private static double Area(double x, double y)
        {
            return x * y;
        }
        // --------------------------------------------------------------------------------------------
        private static double Area(double x, double y, double z)
        {
            return 2 * (x * y + y * z + z * x);
        }
        // -------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.Write("1. 請輸入半徑 : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("1. 圓形的面積為：{0} ", Area(a));
            Console.WriteLine(" --------------------------");
            // ------------------------------------------------------------------- 
            Console.Write("2. 請輸入矩形的長度 : ");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("2. 請輸入矩形的寬度 : ");
            double width1 = double.Parse(Console.ReadLine());
            Console.WriteLine("3. 矩形的面積為：{0} ", Area(length1, width1));
            Console.WriteLine(" ---------------------------");
            // -------------------------------------------------------------------
            Console.Write("3. 請輸入立方體的長度 : ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("3. 請輸入立方體的寬度 : ");
            double width2 = double.Parse(Console.ReadLine());
            Console.Write("3. 請輸入立方體的高度 : ");
            double height2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3. 立方體的表面積為：{0} ", Area(length2, width2, height2));
            Console.WriteLine(" ---------------------------");
            Console.Read();
        }
    }
}
