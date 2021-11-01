using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[100];//定义一个长度为100个数组元素的数组，每个元素占据4个字节的内存
            myArray[0] = 1;//数组的第一个元素的编号一定是从0开始
            Console.WriteLine(myArray[0]);//数组元素也是变量
            Console.WriteLine(Student.Amount);
        }
    }
    class Student
    {
        public static int Amount = 100;
        public int Age;
        public string Name;

        public double add(double a, double b)//此处的a和b就是参数变量（值参数变量）
        {
            double result = a + b;//变量result声明在方法体add里面，所以它是该方法体的局部变量
            return result;
        }
    }
}
