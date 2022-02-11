using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E94091102_W3_practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int map = 0;
            int number = 0;
            Console.Write("地圖大小(1~10):");
            string get = Console.ReadLine();
            try
            {
                map = int.Parse(get);
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入範圍內整數");
            }
            if (map < 1 || map > 11)
            {
                Console.WriteLine("超出範圍");
                System.Environment.Exit(0);
            }
            Console.Write("地雷數量(1~10):");
            get = Console.ReadLine();
            try
            {
                number = int.Parse(get);
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入範圍內整數");
            }
            if (number < 1 || number > 11)
            {
                Console.WriteLine("超出範圍");
                System.Environment.Exit(0);
            }
            int [,] coordinate = new int[map, map];
            int[,] mine_map = new int[map, map];
            for (int a = 0; a < number; a++)
            {
                Console.Write("第 {0} 個地雷的位置(以空白區隔):", a.ToString());
                string location = Console.ReadLine();
                string[] words = location.Split(' ');
                if (int.Parse(words[0]) > map || int.Parse(words[0]) < 0)
                {
                    Console.WriteLine("地雷位置超出範圍");
                    System.Environment.Exit(0);
                }
                if (int.Parse(words[1]) > map || int.Parse(words[1]) < 0)
                {
                    Console.WriteLine("地雷位置超出範圍");
                    System.Environment.Exit(0);
                }
                if (words.Length > 2)
                {
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    System.Environment.Exit(0);
                }
                mine_map[int.Parse(words[0]), int.Parse(words[1])] = 1;
                continue;
            }
            Console.WriteLine("---");
            for (int j = 0; j < map; j++)
            {
                for (int i = 0; i < map; i++)
                {
                    if (mine_map[i, j] == 1)
                    {
                        if ((i - 1) >= 0 && (j - 1) >= 0)
                        {
                            coordinate[(i - 1), (j - 1)]++;
                        }
                        if ((i - 1) >= 0)
                        {
                            coordinate[(i - 1), j]++;
                        }
                        if ((i - 1) >= 0 && map > (j + 1))
                        {
                            coordinate[(i - 1), (j + 1)]++;
                        }
                        if (i >= 0 && (j - 1) >= 0)
                        {
                            coordinate[i, (j - 1)]++;
                        }
                        if (i >= 0 && (j + 1) >= 0)
                        {
                            coordinate[i, (j + 1)]++;
                        }
                        if (map > (i + 1) && (j - 1) >= 0)
                        {
                            coordinate[(i + 1), (j - 1)]++;
                        }
                        if (map > (i + 1) && j >= 0)
                        {
                            coordinate[(i + 1), j]++;
                        }
                        if (map > (i + 1) && map > (j + 1))
                        {
                            coordinate[(i + 1), (j + 1)]++;
                        }
                    }
                }
            }
            for (int d = 0; d < map; d++)
                {
                    for (int c = 0; c < map; c++)
                    {
                        if (mine_map[c, d] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(coordinate[c, d]);
                        }
                        if (c == (map - 1))
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.ReadKey();
        }
    }
}
