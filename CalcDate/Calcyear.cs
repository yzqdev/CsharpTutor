using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CalcDate
{
    public class Calcyear
    {/// <summary>
     /// 根据日期判定是否闰年； </summary>
        public static void calcyear()
        {
            Console.Clear();
            while (true)
            {
                DateTime d;
                Console.WriteLine("请输入年份（用“-”分开）：");
                //能检查日期的合法性，不合法给出提示
                Console.WriteLine("格式如:2018-3-8");
                Regex reg = new Regex(@"\d+[-]\d+[-]\d+");
                x:
                Match m = reg.Match(Console.ReadLine());
                try
                {
                    d = DateTime.Parse(m.Value);
                    int y = Int32.Parse(d.ToString("yyyy"));
                    if (y % 100 == 0)
                    {
                        if (y % 400 == 0)
                        {
                            Console.WriteLine("{0}年是闰年", y);
                        }
                        else
                        {
                            Console.WriteLine("{0}不是闰年", y);
                        }
                    }
                    else
                    {
                        if (y % 4 == 0)
                        {
                            Console.WriteLine("{0}年是闰年", y);
                        }
                        else
                        {
                            Console.WriteLine("{0}不是闰年", y);
                        }
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine("您的输入有问题,请再试一次:");
                    goto x;
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
    }
}