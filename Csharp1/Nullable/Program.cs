using System;

namespace Nullable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            x = 100;
            int? y = null;
            y = y ?? 101;
            Nullable<int> xNullable = null;
            Console.WriteLine(x);
            Console.WriteLine(y);
             Console.WriteLine(xNullable.HasValue);
            xNullable = xNullable.HasValue ? xNullable.Value : 0;
            Console.WriteLine(xNullable.HasValue);
            Console.ReadLine();
        }
    }
}
