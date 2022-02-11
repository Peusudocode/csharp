using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Move(int x, int y, ref string[,] map_array,ref int best_step, ref string[,] best_map, int row, int column,ref int step)
        {
            if (x >= 0 && y >= 0 && x <= (row - 1) && y <= (column - 1) && map_array[x, y] == "X")
            {
                if (step < best_step)
                {
                    if (step != best_step)
                    {
                        best_step = step - 2;
                    }
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            best_map[i, j] = map_array[i, j];
                        }
                    }
                    
                }
                return;
            }
            if (x < 0 || y < 0 || x > (row - 1) || y > (column - 1) || map_array[x, y] == "1" || step == best_step || map_array[x, y] == "*")
            {
                return;
            }

            
            if (map_array[x, y] != "0")
            {
                map_array[x, y] = "*";
            }
            step++;
            Move(x + 1, y, ref map_array,ref best_step, ref best_map, row, column,ref step);
            Move(x - 1, y, ref map_array,ref best_step, ref best_map, row, column,ref step);
            Move(x, y - 1, ref map_array,ref best_step, ref best_map, row, column,ref step);
            Move(x, y + 1, ref map_array,ref best_step, ref best_map, row, column,ref step);

            if (map_array[x, y] != "0")
            {
                map_array[x, y] = " ";
            }
            step--;
        }
 
        static void Main(string[] args)
        {
            int row, column, start_row, start_column, step;
            Console.Write("請輸入迷宮大小(底,高): ");
            string get = Console.ReadLine();
            string[] scope = get.Split(',');
            column = int.Parse(scope[0]);
            row = int.Parse(scope[1]);
            start_column = 0;
            start_row = 0;
            step = 1;
            int best_step = row * column;
            string[,] best_map = new string[row, column];
            string [,] map = new string [row, column];
            Console.WriteLine("請輸入迷宮地圖: ");

            for (int i = 0; i < row; i++)
            {
                get = Console.ReadLine();
                for (int j = 0; j < column; j++)
                {
                    map[i, j] = get.Substring(j, 1);
                    if (get.Substring(j, 1) == "0")
                    {
                        start_row = i;
                        start_column = j;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    best_map[i, j] = map[i, j];
                }
            }
            Move(start_row, start_column, ref map,ref best_step, ref best_map, row, column,ref step);
            Console.WriteLine("Output:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <  column; j++)
                {
                    Console.Write(best_map[i, j]);
                    if (j == (column - 1))
                    {
                        Console.WriteLine();
                    }

                }
            }
            if (best_step == (row * column))
            {
                Console.WriteLine("沒有路徑");
            }
            else
            {
                Console.WriteLine(best_step);
            }
            Console.ReadKey();
        }
    }
}
