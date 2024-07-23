using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    class Rectangle
    {
        public double length;
        private double width;
        double height;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Height: {0}", height);
        }
    }

    class Stone
    {
        public int age;
        public Stone() { }
        public Stone(int age) { }
        public static explicit operator Monkey(Stone stone) { 
            Monkey monkey = new Monkey();
            monkey.age = stone.age/50;
            return monkey;
        }
    }

    class Monkey
    {
        public int age;
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.WriteLine(r.length.ToString());
            //Console.WriteLine(r.width.ToString());
            //Console.WriteLine(r.height.ToString());
            Stone stone = new Stone();
            stone.age = 500;
            Monkey monkey = new Monkey();
            monkey = (Monkey)stone;
            Console.WriteLine(monkey.age.ToString());
            Console.ReadLine();
        }
    }
}
