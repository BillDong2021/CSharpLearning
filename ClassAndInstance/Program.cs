using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            new Form().ShowDialog();//创建类的实例，但没有引用
            Form myForm = new Form();//用引用变量引用新创建的实例
            myForm.Text = "MyTitle";
            myForm.ShowDialog();
        }
    }
}
