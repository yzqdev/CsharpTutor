using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CalcDate
{
    internal class Showweek
    {
        public static void showweek()
        {
            Console.Clear();
            while (true)
            {
                startx:
                string s;
                StreamReader sr = new StreamReader(@"week.txt");
                Console.WriteLine("星期几：");
                while ((s = sr.ReadLine()) != null)
                {
                    Regex reg = new Regex(@"\d\d\d\d-\d\d-\d\d");
                    Match m = reg.Match(s);
                    DateTime dateTime = DateTime.Parse(m.Value);
                    Day week = (Day)((int)dateTime.DayOfWeek);
                    Console.WriteLine(dateTime.ToString("yyyy-MM-dd") + "是" + "{0,10}", week);
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

        public enum Day { Sun = 0, Mon, Tue, Wed, Thu, Fri, Sat }   //枚举类型
    }
}