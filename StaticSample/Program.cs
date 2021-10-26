using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World!");// "Console"这个类可以直接访问"Writeline"这个方法，说明该方法是静态方法，隶属于这个类。
            Form myForm = new Form();
            myForm.Text = "Hello";//实例的属性，因此Text这个属性是这个类（Console）的非静态属性
            myForm.ShowDialog();//实例的方法，因此ShowDialog这个方法是这个类（Console）的非静态方法
        }
    }
}
