using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.ShowDialog();
            Console.ReadLine();
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if (form != null) {
            this.form = form;}
            form.Click += this.FormClicked;
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
