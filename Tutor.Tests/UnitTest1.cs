using NUnit.Framework;
using System;

namespace Tutor.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.Write("hhhh");
            Assert.Pass();
        }
    }
}