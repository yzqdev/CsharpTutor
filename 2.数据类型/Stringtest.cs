using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsoletest
{
    internal class Stringtest
    {
        public void stringtestcompare()
        {
            int result1; bool result2; string s1, s2;
            s1 = "abc"; s2 = "abcd";
            result1 = String.Compare(s1, s2);
            Console.WriteLine(result1);
            result1 = s1.CompareTo(s2);
            Console.WriteLine(result1);
            result2 = s1.Equals(s2);
            Console.WriteLine(result2);
            result2 = String.Equals(s1, s2);
            Console.WriteLine(result2);
        }

        public void stringtestindex()
        {
            string s1 = "java是一门编程语言.";
            int i = s1.IndexOf('是');
            string s2 = s1.Substring(i);
            Console.WriteLine("是的位置是:" + i);
            Console.WriteLine(s2);
        }

        public void stringtestchange()
        {
            string s1 = "visual c# programming";
            string s2 = "      c#       ";
            Console.WriteLine(s1.Replace("c#", "basic"));
            Console.WriteLine(s2.Trim());
        }
    }
}