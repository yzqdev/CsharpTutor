using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication5
{
    class Program
    {
        static string path = null;
        static ArrayList temp = new ArrayList();

        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            ReadFile(arr);
            Handle(arr);
            WriteFile();
            Console.ReadKey();
        }

        static void WriteFile()
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path.Substring(0, path.Length - 4) + ".out");
            }
            catch
            {

            }

            sw.WriteLine("确定天数：");
            for (int i = 0; i < temp.Count; i++)
            {
                sw.WriteLine(temp[i]);
            }
            sw.Close();
            Console.WriteLine("成功！");
        }


        static void Handle(ArrayList arr)
        {

            string[] sp = ((string)arr[0]).Split(' ');
            DateTime start = FormatTime(sp[0]);
            DateTime end = FormatTime(sp[1]);
            TimeSpan ts = setDaysTimeSpan(Int32.Parse(sp[2]));
            for (int i = 1; i < arr.Count; i++)
            {
                string[] spTemp = ((string)arr[i]).Split(' ');
                DateTime startTime;
                DateTime endTemp;
                if (spTemp.Length == 2)
                {
                    startTime = FormatTime(spTemp[0]);
                    endTemp = FormatTime(spTemp[1]);
                }
                else
                {
                    startTime = FormatTime(spTemp[0]);
                    endTemp = FormatTime(spTemp[0]);
                }


                if (ts < startTime - end)
                {
                    string s1 = startTime + "";
                    string s2 = end + "";
                    string str = s2.Substring(0, s2.Length - 7) + "--" + s1.Substring(0, s1.Length - 7);
                    string str1 = "空闲时间：" + (startTime - end);
                    string str2 = "开会日期：" + (end + setDaysTimeSpan(1));
                    temp.Add(str);
                    temp.Add(str1);
                    temp.Add(str2);
                    Console.WriteLine(str);
                    Console.WriteLine(str1.Substring(0, str1.Length - 9) + " 天");
                    Console.WriteLine(str2.Substring(0, str2.Length - 8));
                    break;
                }
                else
                {
                    start = startTime;
                    end = endTemp;
                }
            }

        }


        static public TimeSpan setDaysTimeSpan(int days)
        {
            DateTime d1 = new DateTime(1994, 1, 1, 0, 0, 0);
            DateTime d2 = new DateTime(1994, 1, 2, 0, 0, 0);
            TimeSpan ts1 = d2 - d1;
            TimeSpan ts2 = d1 - d1;
            for (int i = 0; i < days; i++)
            {
                ts2 += ts1;
            }
            return ts2;
        }


        static DateTime FormatTime(string strTime)
        {
            string[] sp = strTime.Split('-');
            Int32.Parse(sp[0]);
            DateTime dt = new DateTime(Int32.Parse(sp[0]), Int32.Parse(sp[1]), Int32.Parse(sp[2]));
            return dt;
        }

        static void ReadFile(ArrayList arr)
        {
            Console.WriteLine("请输入路径");
            //path = Console.ReadLine();
            path = @"D:\1.txt";
            string[] str = File.ReadAllLines(path);
            for (int i = 0; i < str.Length; i++)
            {
                arr.Add(str[i]);
            }
        }
    }
}

