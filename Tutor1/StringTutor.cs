using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor1
{
    internal class StringTutor
    {
        public void stringFunc()
        {
            string hello = "hello world";
            Console.WriteLine(hello);
            string sayHello = hello.Replace("hello", "nemo");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.ReadKey();
        }

        public void searchString()
        {
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
        }
    }
}