using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = -1; 
            int sum = 100;
            do
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();
                int x = 0;
                try
                {
                    x = int.Parse(str1);
                }
                catch
                {
                    Console.WriteLine("First number has problem! Restart.");
                    continue;//放弃继续执行，直接开始一次新的循环
                }
                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();
                int y = 0;
                try 
                { 
                    y = int.Parse(str2); 
                }
                catch
                {
                    Console.WriteLine("Second number has problem! Restart.");
                    continue;
                }
                sum = x + y;
                score++;
            } while (sum==100);
            Console.WriteLine("Your score is {0}.",score);
            Console.WriteLine("Game over");
        }
    }
}
