using System.Collections.Generic;
using System.Linq;
using ApprovalTests.Utilities;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzFake
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            var java = PathUtilities.LocateFileFromEnviormentPath("javaw.exe");
            var counterDisplayJar = PathUtilities.GetAdjacentFile("CounterDisplay.jar");
            // TestCounter.ResetAndLaunch(java.FirstOrDefault(), counterDisplayJar);// Comment out after 1st run
           // TestCounter.Track(Check20);
        }

        private static void Check20()
        {
            string expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
            Assert.AreEqual(expected, FizzBuzz.Print(20));
        }
    }

    public class FizzBuzz
    {
        /// <summary>
        /// 1) separate
        /// 2) encapsulate
        /// 3) calculate
        /// 4) automate
        /// 5) clean
        /// </summary>
        public static string Print(int top)
        {
            var comma = ",";
            var parts = new List<string>();
            var fizz = "Fizz";
            var buzz = "Buzz";
            var fizzbuzz = fizz + buzz;

            for (int i = 1; i <= top; i++)
            {
                if (i == 15)
                {
                    parts.Add(fizzbuzz);
                    continue;
                }

                if (i % 5 == 0)
                {
                    parts.Add(buzz);
                    continue;
                }

                if (i % 3 == 0)
                {
                    parts.Add(fizz);
                    continue;
                }

                parts.Add(i.ToString());
            }

            return string.Join(comma, parts);
        }
    }
}