using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class ClassA
    { };

   internal class ArrayMethod
    {
        static string path = null;
        static ArrayList temp = new ArrayList();

        static void ArrTest(string[] args)
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

    internal class Method
    {
        public void showformat()
        {
        }

        public void caculatetri()
        {
            Console.Write("三角形三边长:a=?,b=?,c=?");
            string abcIn = Console.ReadLine();
            string[] abc = abcIn.Split(' ');
            double a = Convert.ToDouble(abc[0]); double b = Convert.ToDouble(abc[1]); double c = Convert.ToDouble(abc[2]);
            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("三角形面积:{0}", area);
            }
            else
            {
                Console.WriteLine("不能构成三角形");
            }
        }

        /// <summary>
        /// 提取用户名和域名
        /// </summary>
        public void showemail()
        {
            Console.WriteLine("您的email地址是");
            string mail = Console.ReadLine();
            int index = -1;
            index = mail.IndexOf("@");
            if (index < 0)
            {
                Console.WriteLine(mail + "不是有效的emai地址");
            }
            else
            {
                string user = mail.Substring(0, index);
                string domain = mail.Substring(index + 1);
                Console.WriteLine("用户名:{0}", user);
                Console.WriteLine("域名:{0}", domain);
            }
        }

        public void twodemesionarr()
        {
            int[][,] arr = new int[3][,] { new int[,] { { 3, 4 }, { 34, 32 } }, new int[,] { { 34, 53 }, { 34, 53 }, { 3, 2 } }, new int[,] { { 25, 52 }, { 34, 53 }, { 34, 53 }, { 3, 2 } } };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("elments{0}", i);
                Console.WriteLine("_________________");
                int rk = arr[i].Rank;
                int row = arr[i].GetLength(0);
                int col = arr[i].GetLength(1);
                for (int j = 0; j < row; j++)
                {
                    Console.Write("element[{0}][{1}]", i, j);
                    for (int k = 0; k < col; k++)
                    {
                        Console.WriteLine("是{0}{1}", arr[i][j, k], k == col ? "" : "");
                    }
                    Console.WriteLine();
                }
            }
        }

        private void 值类型()
        {
            int n = 5;
            Console.WriteLine("调用方法前变量的值:{0}", n);//输出5
            Squ(n);
            Console.WriteLine("调用方法后变量的:{0}", n);//输出
        }

        private static void Squ(int x)
        {
            x *= x;//x改变不影响x原值
            Console.WriteLine("方法内参数的值:{0}", x);//输出25
        }

        private void 引用类型(int[] yinyong)
        {
            yinyong[0] = 888;//改变影响原数组
            yinyong = new int[5] { -4, -3, -4, -6, -4 };//不改变原数组
        }

        private static readonly String Padding = new String(' ', 30);

        private static IEnumerable<Int32> CreateEnumerable()
        {
            Console.WriteLine("{0} CreateEnumerable()方法开始", Padding);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}开始 yield {1}", i);
                yield return i;
                Console.WriteLine("{0}yield 结束", Padding);
            }
            Console.WriteLine("{0} Yielding最后一个值", Padding);
            yield return -1;
            Console.WriteLine("{0} CreateEnumerable()方法结束", Padding);
        }

        private void ienum()
        {
            IEnumerable<Int32> iterable = CreateEnumerable();
            IEnumerator<Int32> iterator = iterable.GetEnumerator();
            Console.WriteLine("开始迭代");
            while (true)
            {
                Console.WriteLine("调用MoveNext方法……");
                Boolean result = iterator.MoveNext();
                Console.WriteLine("MoveNext方法返回的{0}", result);
                if (!result)
                {
                    break;
                }
                Console.WriteLine("获取当前值……");
                Console.WriteLine("获取到的当前值为{0}", iterator.Current);
            }
            Console.ReadKey();
        }

        private void showtostring()
        {
            object[] obja = new object[6];
            obja[0] = new ClassA();
            
            obja[2] = "hello";
            obja[3] = 123;
            obja[4] = 123.4;
            obja[5] = null;
            for (int i = 0; i < obja.Length; i++)
            {
                string s = obja[i] as string;
                Console.Write("{0}:", i);
                if (s != null)
                {
                    Console.WriteLine(s + "");
                }
                else
                {
                    if (obja[i] == null)
                    {
                        Console.WriteLine("not a string");
                    }
                    else
                    {
                        Console.WriteLine(obja[i].ToString());
                    }
                }
            }
        }
    }
}