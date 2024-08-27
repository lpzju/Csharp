using System;
using System.Collections.Generic;
using System.Linq;
namespace ThisDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double testNum = 3.1415926;
            Console.WriteLine(testNum.ToString());
            double res = Math.Round(testNum, 3);
            Console.WriteLine(res.ToString());
            res = testNum.Round(3);
            Console.WriteLine(res.ToString());
            string testStr = "hello this test";
            testStr.WriteLine();
            List<int> list = new List<int> { 11, 12, 9, 20 };
            // 普通方式
            bool OverTen = list.OverTen();
            Console.WriteLine(OverTen.ToString());
            // LINQ方式
            OverTen = list.All(i => i > 10);
            Console.WriteLine(OverTen.ToString());
            Console.ReadLine();
        }
    }
    public static class MyExtension
    {
        public static double Round(this Double str, int digits)
        {
            double result = Math.Round(str, digits);
            return result;
        }
        public static void WriteLine(this string s)
        {
            Console.WriteLine(s);
        }
        public static bool OverTen(this List<int> list)
        {
            foreach (int i in list)
            {
                if (i > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

// test

