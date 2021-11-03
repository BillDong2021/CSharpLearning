using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnomynousClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person = new { Name = "Tom", Age = 20 };
            Console.WriteLine(Person.Age);
            Console.WriteLine(Person.Name);
            Console.WriteLine(Person.GetType().Name);
        }
    }
}
