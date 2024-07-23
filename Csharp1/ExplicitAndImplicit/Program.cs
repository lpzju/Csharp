using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitAndImplicit
{
    class Monkey
    {
        public double age;
    }

    class StoneExplicit
    {
        public double age;
        public static explicit operator Monkey(StoneExplicit stone)
        {
            Monkey monkey = new Monkey();
            monkey.age = stone.age / 50;
            return monkey;
        }
    }

    class StoneImplicit
    {
        public double age;
        public static implicit operator Monkey(StoneImplicit stone)
        {
            Monkey monkey = new Monkey();
            monkey.age = stone.age / 50;
            return monkey;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StoneExplicit stoneExplicit = new StoneExplicit();
            stoneExplicit.age = 5000;
            StoneImplicit stoneImplicit = new StoneImplicit();
            stoneImplicit.age = 10000;
            Monkey monkey1 = (Monkey) stoneExplicit;
            Monkey monkey2 = (Monkey) stoneImplicit;
            Console.WriteLine(monkey1.age);
            Console.WriteLine(monkey2.age);
            Console.ReadLine();
        }
    }
}
