using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.Click += controller.FormClick;
            form.ShowDialog();
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            this.form = form;
            //this.form.Click += this.FormClick;
        }

        public void FormClick(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
