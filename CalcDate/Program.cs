using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace CalcDate
{
    internal struct HSI
    {
        public string name;
        public DateTime time;
    }

    internal struct MeetingTime
    {
        public int i;
        public DateTime sTime;
        public DateTime eTime;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                int y;
                start:
                start1:
                Console.WriteLine("请输入数字来实现你想要的功能：");
                Console.WriteLine("1------统计时间");
                Console.WriteLine("2------推排日期");
                Console.WriteLine("3------确定日期");
                Console.WriteLine("4------确定星期");
                Console.WriteLine("5------会议管理");
                Console.WriteLine("6------判断闰年");
                Console.WriteLine("0------退出");

                try
                {
                    string x = Console.ReadLine();
                    y = Int32.Parse(x);
                }
                catch (Exception ee)
                {
                    Console.WriteLine("错误,请再试一次");
                    goto start;
                }
                switch (y)
                {
                    case 0: goto start3;
                    case 1: Calcdate.CalcDate(); break;
                    case 2: Dateout.dateout(); break;
                    case 3: Future.future(); break;
                    case 4: Showweek.showweek(); break;
                    case 5: Meeting.meeting(); break;
                    case 6: Calcyear.calcyear(); Console.WriteLine(); break;
                    default: Console.WriteLine("错误,请再试一次"); goto start1;
                }
                start3:

                Console.WriteLine("按任意键继续...");
                Console.ReadKey();
            }
        }
    }
}