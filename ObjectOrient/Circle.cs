using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest2
{
    internal class Circle
    {
        private const double pi = 3.14, x0 = 0, y0 = 0;
        private float radius;

        public float Radius
        {
            get { return radius; }
            set { if (value < 0) { value = 0; } else { radius = value; } }
        }

        public double Area()
        {
            return pi * radius * radius;
        }

        public void Circum()
        {
            Console.WriteLine("圆的周长：{0}", 2 * pi * radius);
        }
    }
}