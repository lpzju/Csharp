using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Val
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            object obj;
            obj = 100; // 这是装箱
            Console.WriteLine(obj);
            dynamic d = 20;
            Console.WriteLine(d);
            dynamic e = 20.1;
            Console.WriteLine(e);
            string str = @"C:\Windows";
            Console.WriteLine(str);
            str = "hello";
            Console.WriteLine(str);
            int i = 10;
            //int* ptr = &i;
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
            Console.WriteLine("num3 的值： {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("num3 的值： {0}", num3);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
