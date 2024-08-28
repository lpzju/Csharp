using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy();
            Timer t = new Timer();
            t.Interval = 1000;
            t.Elapsed += boy.Action;
            t.Start();
            Console.ReadLine();
        }
    }
    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Boy is Jumping!");
        }
    }
}
