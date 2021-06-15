using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CalcDate
{
    internal class Dateout
    {
        private static DateTime timeNow;
        private static HSI[] people = new HSI[100];

        public static void dateout()
        {
            Console.Clear();
            Console.WriteLine("推排日期:");
            while (true)
            {
                startx:
                string s;
                StreamReader sr = new StreamReader(@"date.txt");
                timeNow = System.DateTime.Parse(s = sr.ReadLine());
                Console.WriteLine(timeNow.ToString("yyyy-MM-dd"));
                for (int i = 0; (s = sr.ReadLine()) != null; i++)
                {
                    string[] strArray = s.Split(' ');
                    people[i].name = strArray[0];
                    people[i].time = timeNow.AddDays(Convert.ToDouble(strArray[1]));
                }
                Bubble();
                for (int x = 0; people[x].name != null; x++)
                {
                    Console.WriteLine(people[x].name.PadRight(10) + "{0,10}", people[x].time.ToString("yyyy-MM-dd"));
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
            while (people[x].name != null)
            {
                x++;
            }
            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (DateTime.Compare(people[j].time, people[j + 1].time) > 0)
                    {
                        temp = people[j];
                        people[j] = people[j + 1];
                        people[j + 1] = temp;
                    }
                }
            }
            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (DateTime.Compare(people[j].time, people[j + 1].time) == 0)
                    {
                        string str1 = people[j].name.Substring(0, 1);
                        string str2 = people[j + 1].name.Substring(0, 1);
                        if (str1.CompareTo(str2) == 1)
                        {
                            temp = people[j];
                            people[j] = people[j + 1];
                            people[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}