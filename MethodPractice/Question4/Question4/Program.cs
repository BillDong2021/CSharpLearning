using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            //求一个整形数组的平均值，保留三位小数
            int[] myArray = { 1, 2, 4 };
            double myMean = GetMeanValue(myArray);
            Console.WriteLine("{0:0.000},{1:0.00}",myMean,myMean);//占位符0:0.00 冒号后面规定了输出的格式
            //如果用上述方法，仅仅是输出了两位，实际数字并未保留
            string s = myMean.ToString("0.000");
            myMean = Convert.ToDouble(s);
            Console.WriteLine(myMean);
        }

        public static double GetMeanValue(int[] myArray)
        {
            double mean = 0;
            double sum = 0;
            foreach (var item in myArray)
            {
                sum = sum + item;
            }
            mean = sum / myArray.Length;
            return mean;
        }
    }
}
