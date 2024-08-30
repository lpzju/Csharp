using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.button3.Click += this.ButtonClick;
            //this.button3.Click += new EventHandler(this.ButtonClick);
            //this.button3.Click += delegate (object sender, EventArgs e)
            //{
            //    this.textBox1.Text = "Hello text3 delegate";
            //};
            this.button3.Click += (object sender, EventArgs e) =>
            {
                this.textBox1.Text = "Hello text3 lambda";
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            //this.textBox1.Text = "Hello";
            if (sender == this.button1)
            {
                this.textBox1.Text = "Hello text1";
            }
            if (sender == this.button2)
            {
                this.textBox1.Text = "Hello text2";
            }
            if (sender == this.button3)
            {
                this.textBox1.Text = "Hello text3";
            }
        }
    }
}
