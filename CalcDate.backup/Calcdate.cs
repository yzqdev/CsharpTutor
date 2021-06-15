using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CalcDate
{
    /// <summary>
    /// 人
    /// </summary>

    public class People
    {
        private string name;
        private DateTime backTime;
        private DateTime outTime;
        private Double workTime;

        public string Name             //索引器
        {
            get { return name; }
            set { name = value; }
        }

        public void setBackTime(string d)
        {
            backTime = System.DateTime.Parse(d);
        }

        public void setOutTime(string d)
        {
            outTime = System.DateTime.Parse(d);
        }

        public string getWorkTime()
        {
            if (outTime == default(DateTime) || backTime == default(DateTime))
            {
                return ("出差了,没回来呢");
            }
            else
            {
                workTime = (backTime - outTime).TotalDays;
                return workTime.ToString();
            }
        }
    }    //自定义类，索引器

    internal class Calcdate
    {
        private static People[] people = new People[100];

        public static void CalcDate()
        {
            Console.Clear();
            while (true)
            {
                startx:
                Console.WriteLine("统计时间：");

                for (int x = 0; x < 100; x++)
                {
                    people[x] = new People();
                }

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    int i = 0;
                    string[] strArray = s.Split(' ');
                    while (people[i].Name != null)
                    {
                        if (strArray[0] == people[i].Name)
                        {
                            if (strArray[2].Equals("out"))
                            {
                                people[i].setOutTime(strArray[1]); break;
                            }
                            else
                            {
                                people[i].setBackTime(strArray[1]); break;
                            }
                        }
                        i++;
                    }
                    if (people[i].Name == null)
                    {
                        people[i].Name = (strArray[0]);
                        if (strArray[2].Equals("out"))
                        {
                            people[i].setOutTime(strArray[1]);
                        }
                        else
                        {
                            people[i].setBackTime(strArray[1]);
                        }
                    }
                }
                Bubble();
                for (int m = 0; people[m].Name != null; m++)
                {
                    Console.WriteLine(people[m].Name.PadRight(15) + "{0,5}", people[m].getWorkTime());
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

        private static void Bubble()
        {
            People temp = new People();
            int x = 0;
            while ((people[x].Name) != null)
            {
                x++;
            }
            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    string str1 = people[j].Name.Substring(0, 1);
                    string str2 = people[j + 1].Name.Substring(0, 1);
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