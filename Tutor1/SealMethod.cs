using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class SealMethod
    {
    }

    public class Vehicle
    {
        public virtual void X()
        {
            Console.WriteLine("无法虚");
        }
    }

    //密封类
    //不想让类继承
    //可以更快运行优化
    internal class Car : Vehicle
    {
        //密封方法必须同时使用sealed及override才能使用
        public sealed override void X()
        {
            Console.WriteLine("密封方法");
        }
    }
}