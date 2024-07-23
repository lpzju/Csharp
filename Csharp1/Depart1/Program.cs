using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depart2;

namespace Depart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassHello ch = new ClassHello();
            ch.SayHello();
            Class1 c2 = new Class1();
            c2.SayClass2();
            Console.WriteLine(Calculator.Class1.add(3, 4));
            Console.WriteLine(Calculator.Class1.sub(3, 4));
            Console.WriteLine(Calculator.Class1.mul(3, 4));
            Console.WriteLine(Calculator.Class1.div(3, 4));
            Console.WriteLine(Calculator.Class1.div(3, 0));
            Console.ReadLine();
        }
    }
}
