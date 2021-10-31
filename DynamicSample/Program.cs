using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "Hello!";
            Console.WriteLine(myVar);
        }
    }
}
