using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal interface IPeople
    {
        string Name { get; set; }
        string Sex { get; set; }
    }

    internal interface ITeacher : IPeople
    {
        void teach();
    }

    internal interface IStudent : IPeople
    {
        void study();
    }

    internal class IPeo : IPeople, ITeacher, IStudent
    {
        private string name = "";
        private string sex = "";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void study()
        {
            Console.WriteLine(Name + " " + Sex + "学生");
        }

        public void teach()
        {
            Console.WriteLine(Name + " " + Sex + "老师");
        }
    }
}