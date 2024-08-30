using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.ShowDialog();
        }
    }
    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;
        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.button.Text = "click";
            this.button.Top = 20;
            this.Controls.Add(textBox);
            this.Controls.Add(button);
            this.button.Click += this.ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello !!!!!!!!";
        }
    }
}
