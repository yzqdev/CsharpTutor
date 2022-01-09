using BankSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankSystem // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //创建超市对象
            SupperMarket sm = new SupperMarket();
            //展示货物
            sm.ShowPros();
            //跟用户交互
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}