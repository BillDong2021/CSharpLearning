using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序,从小到大{3, 2, 15, 3, 9, 22, 7, 4, 6, 8}
            int[] myArray = { 3, 2, 15, 3, 9, 22, 7, 4, 6, 8 };
            //int[] myArray2 = myArray;
            //这是一种错误的赋值方法，由于数组是引用类型，会导致变量myArray和myArray2存的都是数组的地址
            //所以对不论对myArray和myArray2哪个变量操作，都会改变原来数组的数据
            int[] myArray2 = new int[myArray.Length];
            myArray.CopyTo(myArray2, 0);//要复制到的字符串，初始位
            Array.Sort(myArray2);
            int myTemp;
            Console.Write("初始的数组为");
            foreach (var item in myArray)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();//可以这样换行
            Console.Write("用Array.Sort的排序结果为");
            foreach (var item in myArray2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int length = myArray.Length;
            for (int j = 0; j < length-1; j++)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        myTemp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = myTemp;
                    }
                }
            }
            Console.Write("冒泡法排序后数组为");
            foreach (var item in myArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
