using NUnit.Framework;
using System;
using System.Drawing;
using System.IO;
using Class_Library_Assignment;


namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestSequentialSearch()
        {
            string Expected = "Result Found: 2";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.TestSequentialSearch();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test]
        public void TestBinarySearch()
        {
            string Expected = "Could not find the result";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.TestBinarySearch();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test]
        public void TestBubbleSortWithCompareTo()
        {
            string Expected = "BubbleSorted";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.TestBubbleSort();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }


    }
}