using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Class1
    {
        public static double add(double x, double y) {  return x + y; }
        public static double sub(double x, double y) { return x - y; }
        public static double mul(double x, double y) {return x * y; }
        public static double div(double x, double y)
        {
            if (x == 0) return double.PositiveInfinity;
            else { return x / y; }
        }
    }
}
