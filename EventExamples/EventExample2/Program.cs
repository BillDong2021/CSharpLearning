using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.Click += myForm.FormClicked;
            myForm.ShowDialog();
        }
    }
    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
