using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CalcDate
{
    internal class Meeting
    {
        public static MeetingTime[] meetingTime = new MeetingTime[100];

        public static void meeting()
        {
            Console.Clear();
            while (true)
            {
                startx:
                DateTime sTime, eTime;
                int max;
                StreamReader sr = new StreamReader(@"meeting.txt");
                string s = sr.ReadLine();
                max = Int32.Parse(new Regex(@"\d$").Match(s).Value);
                sTime = DateTime.Parse(new Regex(@"(\d\d\d\d-\d\d-\d\d)").Match(s).Value);
                eTime = DateTime.Parse(new Regex(@"(\d\d\d\d-\d\d-\d\d)").Match(s).NextMatch().Value);
                Console.WriteLine("安排会议：");
                int i = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    Regex reg = new Regex(@"(\d\d\d\d-\d\d-\d\d)");
                    Regex reg1 = new Regex(@"(\d\d\d\d-\d\d-\d\d)$");
                    Match m = reg.Match(s);
                    Match m1 = reg1.Match(s);
                    meetingTime[i] = new MeetingTime();
                    meetingTime[i].sTime = DateTime.Parse(m.Value);
                    meetingTime[i].eTime = DateTime.Parse(m1.Value);
                    meetingTime[i].i = 1;
                    i++;
                }
                Bubble();
                mymeeting(sTime, eTime, max);
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

        /// <summary>
        /// 冒泡排序法
        /// </summary>
        private static void Bubble()
        {
            MeetingTime temp = new MeetingTime();
            int x = 0;
            while (meetingTime[x].i == 1)
            {
                x++;
            }
            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (DateTime.Compare(meetingTime[j].sTime, meetingTime[j + 1].sTime) > 0)
                    {
                        temp = meetingTime[j];
                        meetingTime[j] = meetingTime[j + 1];
                        meetingTime[j + 1] = temp;
                    }
                }
            }
        }

        private static void mymeeting(DateTime s, DateTime e, int totalTime)
        {
            DateTime meeting = new DateTime();
            if (Int32.Parse((meetingTime[0].sTime - s).TotalDays.ToString()) >= totalTime)
            {
                meeting = s;
            }
            for (int i = 1; meetingTime[i].i == 1; i++)
            {
                if (Int32.Parse((meetingTime[i].sTime - meetingTime[i - 1].eTime).TotalDays.ToString()) > totalTime)
                {
                    meeting = meetingTime[i - 1].eTime;
                    totalTime = Int32.Parse((meetingTime[i].sTime - meetingTime[i - 1].eTime).TotalDays.ToString());
                }
            }
            Console.WriteLine(meeting.AddDays(1).ToString("yyyy-MM-dd"));
        }
    }
}