using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class NumTutor
    {
        public void cycling()
        {
            for (int i = 1; i < 6; i++)

            {
                int n = 0;

                string[] str1 = new string[10];
                for (n = 0; n < 5 - i; n++)
                {
                    str1[n] = " ";

                    Console.Write(str1[n]);
                }

                for (n = 5 - i; n < 4 + i; n++)
                {
                    str1[n] = "A";
                    Console.Write(str1[n]);
                }

                Console.WriteLine();
            }

            for (int j = 1; j < 4; j++)
            {
                int m = 0;

                string[] str2 = new string[10];

                for (m = 0; m < 5 - j; m++)
                {
                    str2[m] = " ";
                    Console.Write(str2[m]);
                }
                for (m = 5 - j; m < 4 + j; m++)
                {
                    str2[m] = "B";
                    Console.Write(str2[m]);
                }
                Console.WriteLine();
            }
        }

        public void hownum()
        {
            while (true)
            {
                Console.WriteLine("请输入运算数");
                string inputnumber = Console.ReadLine();
                string[] str = inputnumber.Split(' ');
                for (int i = 0; i < str.Length; i++)
                {
                    int x = Convert.ToInt32(str[i]);
                    int a = x % 3;
                    int b = x % 5;
                    int c = x % 7;
                    if (a == 0)

                    {
                        Console.WriteLine("{0}除以3等于" + x / 3);
                    }
                    else
                    {
                        Console.WriteLine(x + "不能被3整除");
                    }
                    if (b == 0)

                    {
                        Console.WriteLine("{0}除以5等于" + x / 5);
                    }
                    else
                    {
                        Console.WriteLine(x + "不能被5整除");
                    }
                    if (c == 0)

                    {
                        Console.WriteLine("{0}除以7等于" + x / 7);
                    }
                    else
                    {
                        Console.WriteLine(x + "不能被7整除");
                    }
                    Console.WriteLine("按enter键键入下一个数");
                }
            }
        }
    }
}