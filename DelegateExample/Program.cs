using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCal = new Calculator();
            Action myAction = new Action(myCal.Report);//创建action类型的实例，只能指向参数列表和返回值都为空的方法
            myCal.Report();//直接调用
            myAction.Invoke();//间接调用
            myAction();//与上一行效果一样

            Func<int, int, int> myFunc1 = new Func<int, int, int>(myCal.Add);//参数1，参数2，返回值
            Func<int, int, int> myFunc2 = new Func<int, int, int>(myCal.Sub);//参数1，参数2，返回值

            int x = 100;
            int y = 200;
            int z = 0;

            z = myFunc1.Invoke(x, y);
            Console.WriteLine(z);
            z = myFunc2.Invoke(x, y);
            Console.WriteLine(z);
            z = myFunc1(x,y);
            Console.WriteLine(z);
            z = myFunc2(x, y);//几种写法完全等价
            Console.WriteLine(z);
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Sub(int a,int b)
        {
            int result = a - b;
            return result;
        }
    }   
}
