using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest
{
    internal class Consoletest
    {
        public void consoleline()
        {
            string s1 = "a little cute cat";
            string s2 = ",you are cute too";
            string s3 = s2 + s1.Substring(3);
            Console.WriteLine(s3);
        }

        public void consoleread()
        {
            string stuId, stuName;
            int stuAge, score;

            Console.WriteLine("请输入id:");

            stuId = Console.ReadLine();

            Console.WriteLine("请输入姓名:");
            stuName = Console.ReadLine();

            Console.WriteLine("请输入年龄:");
            stuAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入分数:");
            score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("id是" + stuId + "姓名为" + stuName + "年龄是" + stuAge + "的同学的分数是" + score);
        }

        public void consoleshowkey()
        {
            ConsoleKeyInfo consolekeyinfo;
            do
            {
                consolekeyinfo = Console.ReadKey();
            }
            while (consolekeyinfo.Key == ConsoleKey.Escape);
        }

        #region
        //       快捷键ctrl+k+s;
        //       do
        //{
        //} while (true);
        //   }
        #endregion
    }
}