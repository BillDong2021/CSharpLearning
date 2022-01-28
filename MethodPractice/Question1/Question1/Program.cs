using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 提示用户输入两个数字，计算这两个数字之间所有整数的和
            // 1.用户只能输入数字  2.第一个数必须比第二个小
            Number myNumber = new Number();
            myNumber.GetTwoNumber(out int number1, out int number2);
            while (number1>number2)
            {
                Console.WriteLine("数字1必须小于数字2，请重新输入");
                myNumber.GetTwoNumber(out number1, out number2);
            }
            Calculator myCalculator = new Calculator();
            int result = myCalculator.Calculate(number1,number2);
            Console.WriteLine("计算结果为{0}", result);
            Console.ReadKey();
        }
    }
    class Number
    {
        public int GetNumber()
        {
            string myNumber = Console.ReadLine();
            bool inputResult = int.TryParse(myNumber, out int number);
            while (!inputResult)//如果输入的不是数字，则重新输入
            {
                Console.WriteLine("请重新输入数字");
                myNumber = Console.ReadLine();
                inputResult = int.TryParse(myNumber, out number);
            }
            return number;
        }
        public void GetTwoNumber(out int number1,out int number2)
        {
            Console.WriteLine("请输入第一个数字");
            number1 = this.GetNumber();
            Console.WriteLine("请输入第二个数字");
            number2 = this.GetNumber();
        }
    }
    class Calculator
    {
        public int Calculate(int a, int b)
        {
            int result = 0 ;
            while (a+1<b)
            {
                a = a + 1;
                result = result + a;
            }
            return result;
        }
    }
}
