using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Basics
{
    internal class ListFuncTest
    {
        [Test]
        public void ListFuncs()
        {
            ArrayList list = new ArrayList();
            //添加单个元素
            list.Add(true);
            list.Add(1);
            list.Add("张三");
            //添加集合元素
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //list.AddRange(list);

            //list.Clear();清空所有元素
            //list.Remove(true);删除单个元素 写谁就删谁
            //list.RemoveAt(0);根据下标去删除元素
            //list.RemoveRange(0, 3);根据下标去移除一定范围的元素
            // list.Sort();//升序排列
            //list.Reverse();反转
            //list.Insert(1, "插入的");在指定的位置插入一个元素
            //list.InsertRange(0, new string[] { "张三", "李四" });在指定的位置插入一个集合
            //bool b = list.Contains(1);判断是否包含某个指定的元素
            list.Add("颜世伟");
            if (!list.Contains("颜世伟"))
            {
                list.Add("颜世伟");
            }
            else
            {
                Console.WriteLine("已经有这个屌丝啦");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
        [Test]
        public void ListCount()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
            //count 表示这个集合中实际包含的元素的个数
            //capcity 表示这个集合中可以包含的元素的个数
        }
        [Test]
        public void GenericList()
        {
            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            list.AddRange(list);

            //List泛型集合可以转换为数组
            //int[] nums = list.ToArray();

            //List<string> listStr = new List<string>();

            //string[] str = listStr.ToArray();


            //char[] chs = new char[] { 'c', 'b', 'a' };
            //List<char> listChar = chs.ToList();
            //for (int i = 0; i < listChar.Count; i++)
            //{
            //    Console.WriteLine(listChar[i]);
            //}

            ////   List<int> listTwo = nums.ToList();


            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
        }
        [Test]
        public void DictTest()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王五");
            dic[1] = "新来的";
            foreach (KeyValuePair<int, string> kv in dic)
            {
                Console.WriteLine("{0}---{1}", kv.Key, kv.Value);
            }

            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine("{0}---{1}",item,dic[item]);
            //}
             
        }
    }
}
