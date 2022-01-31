using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question6：反转一个字符串的内容
            //解：用Linq里Enumerable类的Reserve方法
            //string s = "一二三四";
            //string sReverse = Test.Reverse(s);
            //Console.WriteLine(s);
            //Console.WriteLine(sReverse);

            //Question7：计算任意多个数间的最大值
            //解：用Linq里Enumerable类的Sum方法，Sum, Average, Min, Max,Aggregate都可以求
            //double[] myArray = { 1.2, 3.4, 5.6, 7.8 };
            //Console.WriteLine(Test.Max(myArray));

        }
    }
    class Test
    {
        public static string Reverse(string myString)
        {
            return new string(myString.ToCharArray().Reverse().ToArray());
        }
        public static double Max(double[] myArray)
        {
            return myArray.Max();
        }
    }
}
