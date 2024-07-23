using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = new int[] { 1, 2, 3 };
            Console.WriteLine(arr1);
            Console.WriteLine(arr1[0]);
            int[] arr2 = new int[10];
            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i*i;
            }
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
