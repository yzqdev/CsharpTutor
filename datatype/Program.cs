using System;

namespace datatype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Score s = new Score();
            int[] score = { 23, 51, 98, 23, 452, 11 };
            Console.WriteLine("最大值是:" + s.Max(score));
            //Console.ReadLine();
            s.setv();
            s.arraysort();
            s.arraycopy();

            Program.str(); Program.consoler();
        }

        public static void str()
        {
            Stringtest stringtest = new Stringtest();
            stringtest.stringtestcompare();
            stringtest.stringtestindex();
            stringtest.stringtestchange();
        }

        public static void consoler()
        {
            Consoletest consoletest = new Consoletest();
            consoletest.consoleline();
            consoletest.consoleread();
            consoletest.consoleshowkey();
        }
    }
}