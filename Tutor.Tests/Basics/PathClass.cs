using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Basics
{
    internal class PathClass
    {
        [Test]
        public void PathFunc1()
        {
            string str = @"C:\Windows\win.ini";
            //获得文件名
            Console.WriteLine(Path.GetFileName(str));
            //获得文件名但是不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //获得文件所在的文件夹的名称
            Console.WriteLine(Path.GetDirectoryName(str));
            //获得文件所在的全路径
            Console.WriteLine(Path.GetFullPath(str));
            //连接两个字符串作为路径
            Console.WriteLine(Path.Combine(@"c:\a\", "b.txt"));


        }
        [Test]
        public void FileFunc1()
        {
            //创建一个文件
            //File.Create(@"C:\Users\SpringRain\Desktop\new.txt");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除一个文件
            //File.Delete(@"C:\Users\SpringRain\Desktop\new.txt");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();
            //1024byte=1kb
            //1024kb=1M
            //1024M=1G
            //1024G=1T
            //1024T=1PT

            //复制一个文件
            //File.Copy(@"C:\Users\SpringRain\Desktop\code.txt", @"C:\Users\SpringRain\Desktop\new.txt");
            //Console.WriteLine("复制成功");
            //Console.ReadKey();


            //剪切
            File.Move(@"C:\Users\SpringRain\Desktop\code.txt", @"C:\Users\SpringRain\Desktop\newnew.txt");
            Console.WriteLine("剪切成功");
            Console.ReadKey();
        }
        [Test]
        public void FileFunc2()
        {
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\1.txt");


            //EncodingInfo[] en = Encoding.GetEncodings();
            //foreach (var item in en)
            //{
            //    Console.WriteLine(item.DisplayName);
            //}
            //Console.ReadKey();
            //将字节数组转换成字符串
            //string s = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(s);
            // Console.WriteLine(buffer.ToString());
            //编码格式：指的就是你以怎样的形式来存储字符串
            //a-z 0-9  Ascii  117 u---->汉字--->GB2312 GBK
            //int n = (int)'u';
            //char c = (char)188;
            //Console.WriteLine(c);
            ////Console.WriteLine(n);


            //string s="今天天气好晴朗，处处好风光";
            ////将字符串转换成字节数组
            //byte[] buffer=  Encoding.Default.GetBytes(s);
            ////以字节的形式向计算机中写入文本文件
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\1.txt", buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();


            //使用File类来实现一个多媒体文件的复制操作

            //读取
            byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\12333.wmv");
            Console.ReadKey();

            ////写入
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\new.wav", buffer);
            //Console.WriteLine("复制成功");
            //Console.ReadKey();


            //byte[] buffer=new byte[1024*1024*5];
            //while (true)
            //{
            //    File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\123.wmv", buffer);
            //}
        }
        [Test]
        public void FileReadTest()
        {
            //  FileStream StreamReader StreamWriter
            //using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\1.wmv", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[fsRead.Length];
            //    //表示本次读取实际读取到的有效字节数
            //    int r = fsRead.Read(buffer, 0, buffer.Length);

            //    string s = Encoding.Default.GetString(buffer, 0,r);
            //    Console.WriteLine(s);
            //}

            //using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\1.txt", FileMode.Append, FileAccess.Write))
            //{ 
            //    string s="今天天气好晴朗";
            //    byte[] buffer=Encoding.Default.GetBytes(s);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入成功");

            //Console.ReadKey();

            //using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fsRead,Encoding.Default))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }
            //}
            //byte[] buffer = new byte[1024 * 1024];
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\SpringRain\Desktop\1.txt", true, Encoding.Default, buffer.Length))
            //{
            //    sw.WriteLine("哈哈哈");
            //}
            //Console.WriteLine("OK");

            //Console.ReadKey();

        }
    }
}
