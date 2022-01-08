using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Algo
{
    internal class BasicTest
    {
        [Test]
        public void RunTest()
        {
            Console.WriteLine(IsRun(2000));
        }
        [Test]
        public void OutFunc()
        {
            int n;
            bool b = MyTryParse("123", out n);
            Console.WriteLine(b);
            Console.WriteLine(n);
             
        }

        public static bool MyTryParse(string s, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }

    }
}
