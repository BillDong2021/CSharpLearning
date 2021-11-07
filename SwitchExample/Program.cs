using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 101;
            switch (score / 10)
            {
                case 10:
                    if (score == 100)
                    {
                        goto case 8;//为了保持代码的一致性，写goto语句，不直接写CW“A”
                    }
                    else
                    {
                        goto default;
                    }
                case 9:
                case 8:
                    Console.WriteLine("A");
                    break;
                case 7:
                case 6:
                    Console.WriteLine("B");
                    break;
                case 5:
                case 4:
                    Console.WriteLine("C");
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            Level myLevel = Level.High;
            switch (myLevel)
            {
                case Level.High:
                    break;
                case Level.Mid:
                    break;
                case Level.Low:
                    break;
            }
        }
    }

    enum Level
           {
            High,
            Mid,
            Low
           }
}
