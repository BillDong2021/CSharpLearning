using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出一个字符串数组中最长的那个字符串并输出
            //{"马龙","迈克尔乔丹","梅西","亚历山大","托雷斯"}
            string[] myString = { "马龙", "迈克尔乔丹", "梅西", "亚历山大", "托雷斯" };
            Console.Write("初始字符串分别为：");
            foreach (var item in myString)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            string myLongestString = GetLongestString(myString);
            Console.WriteLine("最大字符串是{0}", myLongestString);
        }

        public static string GetLongestString (string[] myString)
        {
            int[] myArray = new int[myString.Length];
            int maxNumber = 0;
            int maxIndex = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                myArray[i] = myString[i].Length;//将每个字符串长度存入myArray中
                if (maxNumber < myArray[i])
                {
                    maxNumber = myArray[i];
                    maxIndex = i;
                }
            }
            return myString[maxIndex];
        }
    }
}
