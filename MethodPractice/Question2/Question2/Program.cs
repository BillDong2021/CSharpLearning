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
            int myTemp;
            Console.Write("初始的数组为");
            foreach (var item in myArray)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();//可以这样换行
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
            Console.Write("排序后数组为");
            foreach (var item in myArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
