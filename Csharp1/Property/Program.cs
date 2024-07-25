using System.Collections.Generic;
using System;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Age = 10;
            Student.MyProperty = 20;
            Console.WriteLine(student.Age);
            Console.WriteLine(Student.MyProperty);
            Dic dic = new Dic();
            if (dic["math"] == null) {
                Console.WriteLine("null");
            } else
            {
                Console.WriteLine(dic["math"]);
            }
            dic["math"] = 100;
            if (dic["math"] == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(dic["math"]);
            }
                Console.ReadLine();
        }
    }

    class Student
    {
        private int age;

        public int Age
        {
            // value关键字用于定义由set取值函数分配的值。
            get { return age; }
            set { age = value; }
        }
        private static int myVar;

        public static int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public int MyProperty1 { get; set; }
        public int Num { get => num; set => num = value; }

        private int num;
    }

    class Dic
    {
        // 索引器：使对象能够用与数组相同的方式(下标)进行索引
        private Dictionary<string, int> dic = new Dictionary<string, int>();
        public int? this[string subject]
        {
            get
            {
                if (this.dic.ContainsKey(subject))
                {

                    return this.dic[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (this.dic.ContainsKey(subject))
                {
                    this.dic[subject] = value.Value;
                } else
                {
                    this.dic.Add(subject, value.Value);
                }
            }
        }
    }
}
