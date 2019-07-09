using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal class Vehicle
    {
        private string name; public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Move()
        {
            Console.WriteLine("{0}都可以移动", this.name);
        }
    }

    internal class Train : Vehicle
    {
        private string name;

        public override void Move()
        {
            Console.WriteLine("{0}在铁轨上行驶", this.name);
        }
    }

    internal class Car : Vehicle
    {
        private string name;

        public override void Move()
        {
            Console.WriteLine("{0}在公路上行驶", this.name);
        }
    }
}