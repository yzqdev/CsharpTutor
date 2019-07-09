using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal class Methodtest
    {
        public void calcarea()
        {
            Circle ci = new Circle();
            ci.Area();
            ci.Circum();
        }

        public void coll()
        {
            Console.WriteLine("以下是索引器______________");
            Coll cc = new Coll();//创建coll类的对象
            cc[0] = "csharp";//通过索引器给数组元素赋值
            cc[1] = "asp.net";//
            cc[2] = "visual basic";
            for (int i = 0; i < Coll.intMaxNum; i++)//遍历所有的元素
            {
                Console.WriteLine(cc[i]);//通过索引器取值
            }
        }

        /// <summary>
        /// 继承
        /// </summary>
        public void Sfruit()
        {
            Fruit fru = new Fruit("水果");
            Apple apple = new Apple("苹果");
            fru.Color = "无";
            apple.Color = "绿色";
            fru.Information();
            apple.Information();
        }

        /// <summary>
        /// 隐藏基类成员
        /// </summary>
        public void student()
        {
            Student stu = new Student();
            stu.id = "111";
            stu.name = "小名";
            stu.sex = "男";
            Console.WriteLine(stu.GetInfomation());
        }

        public void vehicle()
        {
            Vehicle vh = new Vehicle();
            Train tr = new Train();
            Car cr = new Car();
            vh.Name = "交通局";
            tr.Name = "火车";
            cr.Name = "汽车";
            vh.Move();
            tr.Move();
            cr.Move();
        }

        public void showinfostu()
        {
            Pstudent ps = new Pstudent();//实例化pstudent类对象
            ISstudent istu = ps;//使用派生类对象实例化接口
            istu.StudentCode = "123456";
            istu.StudentName = "小明";
            istu.ShowInfoOfStudent();
        }

        public void itstuteach()
        {
            IPeo ipeo = new IPeo();//实例化类对象
            ITeacher iteacher = ipeo;//使用派生类实例化接口ITeacher
            iteacher.Name = "张春华";
            iteacher.Sex = "男";
            iteacher.teach();

            IStudent istudent = ipeo;//使用派生类实例化接口Istudent
            istudent.Name = "有志起";
            istudent.Sex = "女";
            istudent.study();
        }

        public void icalculate()
        {
            Compute compute = new Compute();
            Icalculate1 icalc1 = compute;
            Console.WriteLine("10+40的值是" + icalc1.Add());
            Icalculate2 icalc2 = compute;
            Console.WriteLine("10+40+50的值是" + icalc2.Add());
        }

        public void showchieng()
        {
            Language lan = new Language();
            lan.Show();
        }

        public void showemployee()
        {
            MREmployee mrem = new MREmployee();
            Employee emp = mrem;
            emp.Code = "mr1244";
            emp.Name = "张学友";
            emp.ShowInfoOfEmployee();
        }

        public void showsealedclass()
        {
            Student1 student1 = new Student1();
            student1.Code = "123456";
            student1.Name = "张三";
            student1.ShowInfoOfPeople();
        }

        public void diedai()
        {
            Diedai die = new Diedai();
            die.Show();
        }
    }
}