using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Basics
{
    internal class StringFuncTest
    {
        [Test]
        public void StringTest1()
        {
            //可以讲string类型 看做是char类型的一个只读数组
            string s = "abcdefg";
            s = "bbcdefg";
            // s[0] = 'b';不能这样做  因为是只读的
            //首先将字符串转换为char类型的数组
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转换为我们的字符串
            s = new string(chs);
            //既然可以将string看做char类型的只读数组，所以我可以通过下标去访问字符串中的某一个元素
            Console.WriteLine(s[0]);
            Console.WriteLine(s);
            
        }
        [Test]
        public void StringBuildTest()
        {
            StringBuilder sb = new StringBuilder();
            string str = null;
            //创建了一个计时器，用来记录程序运行的时间
            //00:00:00.0422166
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for (int i = 0; i < 100000; i++)
            {
                //str += i;
                sb.Append(i);
            }
            sw.Stop();//结束计时
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
        }
        [Test]
        public void StringFunctions()
        {
            //练习一:随机输入你心中想到的一个名字，然后输出它的字符串长度  Length:可以得字符串的长度
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字的长度是{0}",name.Length);
            //Console.ReadKey();


            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////将字符串转换成大写
            ////  lessonOne = lessonOne.ToUpper();
            ////将字符串转换成小写形式
            //// lessonOne = lessonOne.ToLower();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////   lessonTwo = lessonTwo.ToUpper();
            ////   lessonTwo = lessonTwo.ToLower();
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不同");
            //}
            //Console.ReadKey();


            //string s = "a b   dfd _   +    =  ,,, fdf ";
            ////分割字符串Split
            //char[] chs = { ' ', '_', '+', '=', ',' };
            //string[] str = s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();


            //练习：从日期字符串（"2008-08-08"）中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如:2008-01-02,你输出你输入的日期为2008年1月2日

            //string s = "2008-08-08";
            ////  char[] chs = { '-' };
            //string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            //Console.ReadKey();
            //老赵

            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str = str.Replace("老赵", "**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();


            //Substring 截取字符串

            //string str = "今天天气好晴朗，处处好风光";
            //str = str.Substring(1,2);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "今天天气好晴朗，处处好风光";
            //if (str.EndsWith("风"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.ReadKey();


            //string str = "今天天天气好晴朗，天天处天好风光";
            //int index = str.IndexOf('哈',2);
            //Console.WriteLine(index);
            //Console.ReadKey();


            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.LastIndexOf('天');
            //Console.WriteLine(index);
            //Console.ReadKey();


            ////LastIndexOf  Substring
            //string path = @"c:\a\b\c苍\d\e苍\f\g\\fd\fd\fdf\d\vfd\苍老师苍.wav";
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index+1);
            //Console.WriteLine(path);
            //Console.ReadKey();



            // string str = "            hahahah          ";
            //// str = str.Trim();
            // //str = str.TrimStart();
            // str = str.TrimEnd();
            // Console.Write(str);
            // Console.ReadKey();

            //string str = "fdsfdsfds";
            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            ////张三|李四|王五|赵六|田七
            //string strNew = string.Join("|", "张三","李四","王五","赵六","田七");
            //Console.WriteLine(strNew);
            //Console.ReadKey();

        }
        [Test]
        public void StringPractice()
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"

            //string str = "abcdefg";//ggedcba
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}

            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();


            //倒叙循环
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}

            //"hello c sharp"→"sharp c hello"
            //string str = "hello c sharp";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length / 2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - 1 - i];
            //    strNew[strNew.Length - 1 - i] = temp;
            //}

            //str = string.Join(" ", strNew);
            //Console.WriteLine(str);
            //string.join:将字符串按照指定的分隔符连接
            //Console.WriteLine(strNew);//sharp c hello
            // sharp c hello

            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.WriteLine(strNew[i]);
            //}


            //课上练习3：从Email中提取出用户名和域名：abc@163.com。
            //string email = "285014478@qq.com";
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0, index);
            //string yuMing = email.Substring(index+1);
            //Console.WriteLine(yuMing);
            //Console.WriteLine(userName);


            //Console.ReadKey();










            //课上练习4：文本文件中存储了多个文章标题、作者，
            //标题和作者之间用若干空格（数量不定）隔开，每行一个，
            //标题有的长有的短，输出到控制台的时候最多标题长度10，
            //如果超过10，则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。


            //string path = @"C:\Users\SpringRain\Desktop\1.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.Default);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] strNew = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine((strNew[0].Length>10?strNew[0].Substring(0,8)+"......":strNew[0])+"|"+strNew[1]);
            //}
            //Console.ReadKey();




            //历史就是这么回事儿|袁腾飞
            //c#基础之循环结构while、do-while|老赵
            //AV|苍老师
            //坏蛋是怎样炼成的怎样炼成的|六道


            //让用户输入一句话,找出所有e的位置
            //string str = "咳嗽、咳嗽 哈哈咳嗽 咳 咳  咳嗽";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();


            //int index = str.IndexOf('e');
            //Console.WriteLine("第1次出现e的位置是{0}", index);
            ////循环体：从上一次出现e的位置加1的位置找下一次e出现的位置
            ////循环条件：index!=-1
            //int count = 1;//用来记录e出现的次数
            //while (index != -1)
            //{
            //    count++;
            //    index = str.IndexOf('e', index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现e的位置是{1}",count,index);
            //}
            //Console.ReadKey();



            //用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出,如:老牛很邪恶,输出后变成老牛很**;
            //string str = "老牛很邪恶";
            //if (str.Contains("邪恶"))
            //{
            //    str = str.Replace("邪恶", "**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            //把{“诸葛亮”,”鸟叔”,”卡卡西”,”卡哇伊”}变成诸葛亮|鸟叔|卡卡西|卡哇伊,然后再把|切割掉
            string[] names = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string str = string.Join("|", names);
            string[] strNew = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            //  Console.WriteLine(str);
             
        }
    }
}
