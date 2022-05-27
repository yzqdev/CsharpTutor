using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Basics.IoTest
{
    internal class FileTest
    {
        [Test]
        public void WriteFile()
        {
            FileStream fsStream = new FileStream(@"d:\2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            string str1 = "123456";
            byte[] buffer = Encoding.UTF8.GetBytes(str1);
            fsStream.Write(buffer, 0, buffer.Length);
            fsStream.Close();
        }
        [Test]
        public void ReadFile()
        {
            //使用FileStream来读取数据
            FileStream fsRead = new FileStream(@"d:\2.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            //3.8M  5M
            //返回本次实际读取到的有效字节数
            int r = fsRead.Read(buffer, 0, buffer.Length);
            //将字节数组中每一个元素按照指定的编码格式解码成字符串
            string s = Encoding.UTF8.GetString(buffer, 0, r);
            //关闭流
            fsRead.Close();
            //释放流所占用的资源
            fsRead.Dispose();
            Console.WriteLine(s);
        }
    }
}
