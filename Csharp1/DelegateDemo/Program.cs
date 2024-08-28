using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Program
    {
        public delegate int Calcu(int x, int y);
        static void Main(string[] args)
        {
            Type t = typeof(Action);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.IsClass);
            Action action = new Action(SayHello.say);
            action.Invoke();
            Calculator cal = new Calculator();
            Func<int,int,int> test = cal.add;
            Console.WriteLine(test(3, 5));
            Calcu c1 = cal.add;
            Calcu c2 = cal.sub;
            Console.WriteLine(c1(1,9));
            Console.WriteLine(c2(1,9));
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public int add(int x, int y) { return x + y;}
        public int sub(int x,int y) { return x - y;}
    }
    class SayHello
    {
        public static void say() { Console.WriteLine("hello"); }
    }
}
