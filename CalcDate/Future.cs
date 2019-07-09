using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CalcDate
{
    internal class Future
    {
        private static DateTime timeNow;
        private static HSI[] holiday = new HSI[100];

        public static void future()
        {
            Console.Clear();
            while (true)
            {
            startx:
                string s;
                StreamReader sr = new StreamReader(@"future.txt");
                timeNow = System.DateTime.Parse(s = sr.ReadLine());
                Console.WriteLine("当前日期是：" + timeNow.ToString("yyyy-MM-dd"));
                for (int i = 0; (s = sr.ReadLine()) != null; i++)
                {
                    Regex reg = new Regex(@"[a-zA-Z]+");
                    Match m = reg.Match(s);
                    holiday[i].name = m.Value;
                    reg = new Regex(@"\d\d\d\d-\d\d-\d\d");
                    m = reg.Match(s);
                    try
                    {
                        holiday[i].time = DateTime.Parse(m.Value);
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine("输入日期有误");
                    }
                }
                Bubble();
                for (int x = 0; holiday[x].name != null; x++)
                {
                    Console.WriteLine(holiday[x].name.PadRight(20) + "{0,10}", (holiday[x].time - timeNow).TotalDays + "天");
                }
                Console.WriteLine("输入0退出");
                string st;
                while ((st = Console.ReadLine()) != null)
                {
                    if (st.Equals("0")) break;
                    else Console.WriteLine("错误,请再试一次");
                }
                break;
            }
            Console.Clear();
        }

        public static void Bubble()
        {
            HSI temp = new HSI();
            int x = 0;
            while (holiday[x].name != null)
            {
                x++;
            }
            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (DateTime.Compare(holiday[j].time, holiday[j + 1].time) > 0)
                    {
                        temp = holiday[j];
                        holiday[j] = holiday[j + 1];
                        holiday[j + 1] = temp;
                    }
                }
            }
        }
    }
}