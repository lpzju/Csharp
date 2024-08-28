using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.ID = 1;student1.PenColor=ConsoleColor.Green;
            Student student2 = new Student();
            student2.ID = 2; student2.PenColor = ConsoleColor.Yellow;
            Student student3 = new Student();
            student3.ID = 3; student3.PenColor = ConsoleColor.Red;
            Action action1 = new Action(student1.DoHomework);
            Action action2 = new Action(student2.DoHomework);
            Action action3 = new Action(student3.DoHomework);
            //action1 += action2;
            //action1 += action3;
            //action1.Invoke();
            action1.BeginInvoke(null, null);
            action2.BeginInvoke(null, null);
            action3.BeginInvoke(null, null);
            //action2.Invoke();
            //action3.Invoke();
            //student1.DoHomework();
            //student2.DoHomework();
            //student3.DoHomework();
            for (int i = 0; i < 10;i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}", i);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }
        public void DoHomework()
        {
            for(int i = 0; i < 5; i++) {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing homework {1} hours.", this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
