using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum mySum = new Sum();
            int x = mySum.GetSum(100);
            Console.WriteLine(x);
        }
    }

    class Sum
    {
        public int GetSum(int x)
        {
            int result = 0;
            for (int i = 0; i <= x; i++)
            {
                result = result + i;
            }
            return result;
        }
    }
}
