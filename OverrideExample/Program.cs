using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle myCar1 = new vehicle();
            car myCar2 = new car();
            myCar1.Run();
            myCar2.Run();
        }
    }
    class vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("I'm running!");
        }
    }
    class car:vehicle
    {
        public override void Run()
        {
            Console.WriteLine("I'm running too!");
        }
    }
}
