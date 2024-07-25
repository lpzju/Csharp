using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func
{
    public static class Func
    {
        public static int Fact(int x)
        {
            if (x > 1) { 
                return x * Fact(x-1);
            }else
            {
                return 1;
            }
        }
        public static void swap(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void getValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个值： ");
            x = Convert.ToInt32(Console.ReadLine()) + 1;
            Console.WriteLine("请输入第二个值： ");
            y = Convert.ToInt32(Console.ReadLine()) + 2;
        }
    }
    
    class Student
    {
        public int MyProperty { get; set; }
        private int myVar;

        public int MyProperty1
        {
            get { return myVar; }
            set { myVar = value; }
        }
    }


    
    internal class Program
    {
        static void Test1(Student student) {
            student.MyProperty = 1;
            student.MyProperty1 = 2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Func.Fact(5));
            int a = 1;
            int b = 2;
            Console.WriteLine("Swap before, a : {0}, b : {1}", a, b);
            Func.swap(ref a, ref b);
            Console.WriteLine("Swap after, a : {0}, b : {1}", a, b);
            Func.getValues(out a, out b);
            Console.WriteLine("out after, a : {0}, b : {1}", a, b);

            Student student = new Student();
            Console.WriteLine(student.MyProperty);
            Console.WriteLine(student.MyProperty1);
            Test1 (student);
            Console.WriteLine(student.MyProperty);
            Console.WriteLine(student.MyProperty1);
            Console.ReadLine();
        }
    }
}
