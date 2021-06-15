using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2
{
    internal class Employee
    {
        private string name;
        private string sex;
        private int age;
        private string native_place;
        private string tel;
        private string info;

        public string Name
        {
            get { return name; }
        }

        public string Sex
        {
            get
            {
                return sex;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Native_place
        {
            get
            {
                return native_place;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }/// <summary>

        /// Employee类的无参构造函数 </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Employee类的三级构造函数
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <param name="sex">员工性别</param>
        /// <param name="age">员工年龄</param>
        public Employee(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        /// <summary>
        /// Employee类的五级构造函数
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <param name="sex">员工性别</param>
        /// <param name="age">员工年龄</param>
        /// <param name="native_place">员工籍贯</param>
        /// <param name="tel">员工电话</param>
        public Employee(string name, string sex, int age, string native_place, string tel)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.native_place = native_place;
            this.tel = tel;
        }
    }
}