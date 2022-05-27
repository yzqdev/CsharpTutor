using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModifierKeys : uint
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
    public class MainTest
    {
       
        [Test]
        public   void StringToByte(  )
        {
            
            var a = Encoding.Default.GetBytes("VwAAAAcAAAA=");
            Console.WriteLine("tostring="+BitConverter.ToString(a));
            Console.WriteLine("hhhhhh=" + Base64Decode("VwAAAAcAAAA="));
           
        }
       [Test]
       public void Base64ToByte()
        {
            var b = Base64Decode("VwAAAAcAAAA=");
            Console.WriteLine(b);
            byte[] a = Encoding.Default.GetBytes(b);
            Console.WriteLine(BitConverter.ToString(a));
            Console.WriteLine( Encoding.UTF8.GetBytes(b));
        }
        [Test ]
        public void Wgesture()
        { 
            Console.WriteLine(Base64Encode( (30064771159 >> 32).ToString()));
            ModifierKeys modifiers = (ModifierKeys)(9);
            Console.WriteLine(30064771159 >> 32);
            Console.WriteLine(modifiers);
            Console.ReadLine();

        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}