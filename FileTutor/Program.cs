using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfiel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Creatdat creatdat = new Creatdat();
            Readtxt readtxt = new Readtxt();
            //creatdat.mycreatdat();
            //readtxt.myreadtxt();
            readtxt.writetxt2(@"3.txt");
        }
    }
}