using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxAvg
{
    class Program
    {
        private static float FMax(ref float[] tAry)
        {
            float tMax = tAry[0];     // 先假設陣列元素0 為最大值
            for (int i = 0; i <= tAry.Length - 1; i++)
                if (tAry[i] > tMax)   // 若目前陣列元素比tMax大則交換
                    tMax = tAry[i];
            return (tMax);           // 傳回最大值
        }
        // --------------------------------------------------------------------------------------------
        private static float FAvg(ref float[] tAry)
        {
            float tAvg = new float();
            foreach (float n in tAry)
                tAvg += n;
            return tAvg / (tAry.Length - 1);
        }
        // --------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            float[] numAry = new float[6];

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("請輸入第 {0} 數 : ", i);
                numAry[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("最大數為 ：{0} ", FMax(ref numAry));
            Console.WriteLine("平均值為 ：{0} ", FAvg(ref numAry));
            Console.Read();
        }
    }
}
