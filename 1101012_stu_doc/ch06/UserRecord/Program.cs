using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRecord
{
    class Program
    {
        public struct UserRec            // 宣告UserRec結構，內含三個成員
        {
            public string passwd, email;   // 密碼(passwd)、email成員皆為string型別
            public bool sex;             // 性別(sex)成員為bool型別
        }

        static void Main(string[] args)
        {
            UserRec rec;               // 建立UserRec結構型別的變數rec
            // 建立Dictionary類別物件
            Dictionary<string, UserRec> userDict = new Dictionary<string, UserRec>();
            rec.passwd = "123456";         // 指派結構變數rec成員資料
            rec.sex = true;
            rec.email = "cc@yljh.edu.tw";
            userDict.Add("張三榮", rec);    // 加入第一筆資料到userDict物件中
            // ------------------------------------------------------------------------------
            rec.passwd = "111111";
            rec.sex = false;
            rec.email = "mm@hinet.net";
            userDict.Add("李玲玲", rec);    // 加入第二筆資料到userDict物件中

            string name, mail, pw, fm;
            Console.Write("請輸入使用者姓名： ");
            name = Console.ReadLine();      // 登入使用者姓名
            if (!userDict.ContainsKey(name))  // 若userDict物件索引鍵不包含該姓名
                Console.WriteLine("查無此人");
            else                          // 若userDict物件索引鍵包含該姓名
            {
                Console.WriteLine();
                Console.Write("請輸入使用者密碼： ");
                pw = Console.ReadLine();         // 登入使用者密碼
                if (userDict[name].passwd == pw)   // 若使用者密碼相符，顯示資料
                {
                    Console.WriteLine("\n顯示 {0} 相關資料", name);
                    if (userDict[name].sex)
                        fm = "男";
                    else
                        fm = "女";
                    Console.WriteLine("性別： {0}", fm);      // 顯示性別
                    Console.WriteLine("Email： {0}", userDict[name].email); //顯示Email
                }
                else                                 // 若使用者密碼不符
                    Console.WriteLine("密碼不對");
            }

            if (!userDict.ContainsKey("林大山"))
            {
                rec.passwd = "224488";
                rec.sex = true;
                rec.email = "llyy@gmail.com";
                userDict["林大山"] = rec;      // 或 userDict.Add("林大山", rec);
            }

            Console.WriteLine();
            Console.WriteLine("列出所有使用者相關資料");
            Console.WriteLine("姓名\t性別\t密碼\tmail");
            Console.WriteLine("======\t====\t======\t==============");
            foreach (KeyValuePair<string, UserRec> kv in userDict)
            {
                name = kv.Key;
                if (kv.Value.sex)
                    fm = "男";
                else
                    fm = "女";
                pw = kv.Value.passwd;
                mail = kv.Value.email;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", name, fm, pw, mail);
            }
            Console.Read();
        }
    }
}
