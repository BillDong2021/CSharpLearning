using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student myStu = new Student();
                myStu.ID = 1;
                myStu.Score = 99;
                Console.WriteLine(myStu.Score);
                Student* pStu = &myStu;
                pStu->Score = 100;
                Console.WriteLine(myStu.Score);
            }
        }
    }
    struct Student
    {
        public int ID;
        public double Score;
    }
}
