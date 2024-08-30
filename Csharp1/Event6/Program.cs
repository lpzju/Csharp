using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.Click += myForm.MyClicked;
            myForm.ShowDialog();
        }
    }
    class MyForm : Form
    {
        internal void MyClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
