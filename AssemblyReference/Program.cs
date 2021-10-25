using System;
using Tools;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = Calculator.Mul(3, 4);
            Console.WriteLine(result1);
            double result2 = Calculator.Div(3, 0);
            Console.WriteLine(result2);
        }
    }
}
