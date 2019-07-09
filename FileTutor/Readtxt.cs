using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfiel
{
    internal class Readtxt
    {/// <summary>
     /// 使用FileStream类创建文件，然后将数据写入到文件里。 </summary>
        public void writetxt1()
        {
            FileStream fs = new FileStream(@"2.txt", FileMode.Create);
            //获得字节数组
            byte[] data = Encoding.Default.GetBytes("Hello World!");
            //开始写入
            fs.Write(data, 0, data.Length);
            Console.WriteLine("创建成功");
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }

        /// <summary>
        /// 使用FileStream类创建文件，使用StreamWriter类，将数据写入到文件。
        /// </summary>
        public void writetxt2(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            string date = DateTime.Now.ToString("d");
            //开始写入
            sw.Write(date);
            //清空缓冲区
            sw.Flush();
            //关闭流
            Console.WriteLine("创建成功");
            sw.Close();
            fs.Close();
        }

        public void myreadtxt()
        {
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader(@"1.txt"))
                {
                    string line;

                    // 从文件读取并显示行，直到文件的末尾
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("文件不存在");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}