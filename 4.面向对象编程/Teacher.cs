using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal class Teacher
    {
        public string id;
        public string name;
        public string sex;

        public string GetInformation()
        {
            return string.Format("身份证号：{0},姓名:{1},性别：{2}", id, name, sex);
        }
    }

    internal class Student : Teacher
    {/// <summary>
     /// new只是隐藏了基本类中的成员，通过基类的引用任然可以调用被隐藏的基类成员 </summary> <returns></returns>
        public new string GetInfomation()
        {
            return string.Format("学号：{0},姓名:{1},性别：{2}", id, name, sex);
        }
    }
}