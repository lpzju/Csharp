using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{
    class Rectangle
    {
        // 成员变量
        protected double length;
        protected double width;
        public Rectangle()
        {
            Console.WriteLine("Rectangle wucan");
        }
        public Rectangle(double l, double w)
        {
            Console.WriteLine("Rectangle youcan");
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle  
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop()
        {
            Console.WriteLine("Tabletop wucan");
        }
        public Tabletop(double l, double w) : base(l, w)
        { Console.WriteLine("Tabletop youcan"); }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("成本： {0}", GetCost());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}
