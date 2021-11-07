using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "99999999999999999999";
            string b = "456";
            Calculator myCal = new Calculator();
            int c = 0;
            try
            {
                c = myCal.Add(a, b);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(c);//这里输出的0是有问题的0
        }
    }
    class Calculator
    {
        private bool hasError=false;
        public int Add(string x, string y)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(x);
                b = int.Parse(y);
            }
            catch(ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                hasError = true;
            }
            catch(FormatException)
            {
                Console.WriteLine("Your argument(s) are not a number");
                hasError = true;
            }
            catch(OverflowException)
            {
                //Console.WriteLine("Out of range!");
                hasError = true;
                throw;
            }
            finally
            {
                if (hasError)
                {
                    Console.WriteLine("Execution has error");
                }
                else
                {
                    Console.WriteLine("No error!");
                }
            }
            int result = a + b;
            return result;
        }
    }
}
