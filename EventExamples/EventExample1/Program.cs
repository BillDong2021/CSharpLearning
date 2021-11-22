using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer();
            myTimer.Interval = 1000;
            myTimer.Elapsed += MyHandler.MyTimer_Elapsed;
            myTimer.Start();
            Console.ReadLine();
        } 
    }
    class MyHandler
    {
        public static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("jump in {0}!", DateTime.Now.ToString()); 
        }
    }
}
