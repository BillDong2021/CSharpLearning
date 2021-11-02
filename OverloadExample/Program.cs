using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            double x = 1.5;
            double y = 2.0;
            Calculator myCal = new Calculator();
            Console.WriteLine(myCal.Add(a,b));
            Console.WriteLine(myCal.Add(x, y));
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
