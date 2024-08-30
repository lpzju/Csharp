using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Event3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += boy.Action;
            timer .Start();
            Console.ReadLine();
        }
    }
    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Boy is jumpping");
        }
    }
}
