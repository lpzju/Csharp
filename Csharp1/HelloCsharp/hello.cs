using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCsharp
{
    internal class hello
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Csharp");
            Console.WriteLine("Hello World!");
            Form form = new Form();
            form.ShowDialog();
            Console.ReadKey();
        }
    }
}
