using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Basics
{
    internal class SerializeTest
    {
        [Test]
        public void FileSerial()
        {
            //要将p这个对象 传输给对方电脑
            Person p = new Person();
            p.Name = "张三";
            p.Age = 19;
            p.Gender = '男';
            using (FileStream fsWrite = new FileStream(@"d:\1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //开始序列化对象
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, p);
            }
            Console.WriteLine("序列化成功");


            //接收对方发送过来的二进制 反序列化成对象
             
            using (FileStream fsRead = new FileStream(@"d:\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
        }

        [Serializable]
        public class Person
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }


            private char _gender;

            public char Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            private int _age;

            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }
        }
    }
}
