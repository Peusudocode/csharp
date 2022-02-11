using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Send_Card(ref int[,] card_array, ref int card_amount)
        {
            Random ranObj = new Random(Guid.NewGuid().GetHashCode());
            card_array[card_amount, 0] = ranObj.Next(0, 4);
            card_array[card_amount, 1] = ranObj.Next(1, 14);
            card_amount += 1;
        }
        private static int Calculate_Points(int[,] card_array,int card_amount)
        {
            int A_number = 0;
            int user_point = 0;
            for (int i = 0; i <= card_amount; i++)
            {
                if (card_array[i, 1] > 1 && card_array[i, 1] < 11)
                {
                    user_point = user_point + card_array[i, 1];
                }
                else if (card_array[i, 1] >= 11)
                {
                    user_point += 10;
                }
                else if (card_array[i, 1] == 1)
                {
                    A_number += 1;
                }
            }
            if (A_number > 0)
            {
                for (int a = 0; a < A_number; a++)
                {
                    if ((user_point + A_number) < 11)
                    {
                        user_point += 11;
                        continue;
                    }
                    else if ((user_point + A_number) > 11)
                    {
                        user_point += 1;
                        continue;
                    }
                }
            }
            return user_point;
        }
        private static void Paid_Money(ref int user_paid, int user_money)
        {
            try
            {
                Console.Write("請輸入下注金額: ");
                string get = Console.ReadLine();
                if (int.Parse(get) > 0 && int.Parse(get) <= user_money)
                {
                    user_paid = int.Parse(get);
                }
                else if (int.Parse(get) > user_money)
                {
                    Console.WriteLine("金錢不足，請重新輸入!");
                    Paid_Money(ref user_paid, user_money);
                }
                else if (int.Parse(get) == 0)
                {
                    Console.WriteLine("金錢不能為零，請重新輸入!");
                    Paid_Money(ref user_paid, user_money);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                System.Environment.Exit(0);
            }
        }
        private static void Payment(ref int loss_paid,ref int win_money, ref int loss_money)
        {
            win_money = win_money + loss_paid;
            loss_money = loss_money - loss_paid;
            if (loss_money <= 0)
            {
                System.Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            int user1_money = 0;
            int user2_money = 0;
            int user1_paid = 0;
            int user2_paid = 0;
            Console.Write("玩家1初始金錢: ");
            string get = Console.ReadLine();
            try
            {
                user1_money = int.Parse(get);
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                System.Environment.Exit(0);

            }
            Console.Write("玩家2初始金錢: ");
            get = Console.ReadLine();
            try
            {
                user2_money = int.Parse(get);
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                System.Environment.Exit(0);

            }
            Console.WriteLine("----------------------------------");
            while (true)
            {
                user1_paid = 0;
                user2_paid = 0;
                string[] color = new string[] { "Spade", "Heart", "Diamond", "Club" };
                int[,] user1_card = new int[10, 2];
                int[,] user2_card = new int[10, 2];
                int user1_card_amount , user2_card_amount, user1_point, user2_point;
                user1_card_amount = 0;
                user2_card_amount = 0;
                user1_point = 0;
                user2_point = 0;
                Send_Card(ref user1_card, ref user1_card_amount);
                Send_Card(ref user1_card, ref user1_card_amount);
                Send_Card(ref user2_card, ref user2_card_amount);
                Send_Card(ref user2_card, ref user2_card_amount);
                Console.WriteLine("玩家1手牌: {0} {1}, {2} {3}", color[user1_card[0, 0]], user1_card[0, 1], color[user1_card[1, 0]], user1_card[1, 1]);
                user1_point = Calculate_Points(user1_card, user1_card_amount);
                Console.WriteLine("玩家1目前點數: {0}", user1_point);
                Console.WriteLine("玩家1目前金錢: {0}", user1_money);
                Paid_Money(ref user1_paid, user1_money);
                Console.WriteLine("玩家2手牌: {0} {1}, {2} {3}", color[user2_card[0, 0]], user2_card[0, 1], color[user2_card[1, 0]], user2_card[1, 1]);
                user2_point = Calculate_Points(user2_card, user2_card_amount);
                Console.WriteLine("玩家2目前點數: {0}", user2_point);
                Console.WriteLine("玩家2目前金錢: {0}", user2_money);
                Paid_Money(ref user2_paid, user2_money);
                while (true)
                {
                    Console.WriteLine("玩家1行動(輸入1抽1張排、輸入P停止抽牌):");
                    get = Console.ReadLine();
                    if (get == "1")
                    {
                        Send_Card(ref user1_card, ref user1_card_amount);
                        Console.Write("玩家1手牌: ");
                        for (int k = 0; k < user1_card_amount; k++)
                        {
                        Console.Write("{0} {1}, ", color[user1_card[k, 0]], user1_card[k, 1]);
                        }
                        Console.WriteLine();
                        user1_point = Calculate_Points(user1_card, user1_card_amount);
                        Console.WriteLine("玩家1目前點數: {0}", user1_point);
                        if (user1_point > 21)
                        {
                            break;
                        }
                    }
                    else if (get == "p")
                    {
                        Console.WriteLine("玩家1跳過，目前點數:{0}", user1_point);
                        break;
                    }
                }
                if (user1_point > 21)
                {
                    Console.WriteLine("玩家1爆了，玩家2獲勝!");
                    Console.WriteLine("玩家2獲勝，獲得{0}金錢", user1_paid);
                    Payment(ref user1_paid, ref user2_money, ref user1_money);
                    continue;
                }
                while (true)
                {
                    Console.WriteLine("玩家2行動(輸入1抽1張排、輸入P停止抽牌):");
                    get = Console.ReadLine();
                    if (get == "1")
                    {
                        Send_Card(ref user2_card, ref user2_card_amount);
                        Console.Write("玩家2手牌: ");
                        for (int k = 0; k < user2_card_amount; k++)
                        {
                            Console.Write("{0} {1}, ", color[user2_card[k, 0]], user2_card[k, 1]);
                        }
                        Console.WriteLine();
                        user2_point = Calculate_Points(user2_card, user2_card_amount);
                        Console.WriteLine("玩家2目前點數: {0}", user2_point);
                        if (user2_point > 21)
                        {
                            break;
                        }
                    }
                    else if (get == "p")
                    {
                        Console.WriteLine("玩家2跳過，目前點數:{0}", user2_point);
                        break;
                    }
                }
                if (user2_point > 21)
                {
                    Console.WriteLine("玩家2爆了，玩家1獲勝!");
                    Console.WriteLine("玩家1獲勝，獲得{0}金錢", user2_paid);
                    Payment(ref user2_paid, ref user1_money, ref user2_money);
                    continue;
                }
                else if (user1_point > user2_point)
                {
                    Console.WriteLine("玩家1獲勝，獲得{0}金錢", user2_paid);
                    Payment(ref user2_paid, ref user1_money, ref user2_money);
                }
                else if (user2_point > user1_point)
                {
                    Console.WriteLine("玩家2獲勝，獲得{0}金錢", user1_paid);
                    Payment(ref user1_paid, ref user2_money, ref user1_money);
                }
                else if (user1_point == user2_point)
                {
                    Console.WriteLine("平手!拿回各自的錢");
                }

            }
            Console.ReadKey();
        }
    }
}
