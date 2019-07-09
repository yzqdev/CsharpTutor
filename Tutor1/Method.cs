using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class ClassA
    { };

    internal class ClassB
    { };

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
            obja[1] = new ClassB();
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