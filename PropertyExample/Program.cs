using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStu = new Student();
            myStu.Age = 10;
            Console.WriteLine(myStu.CanWork);

            try
            {
                Student.Amount = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Student
    {
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age value has error");
                }
            }
        }

        private static int amount;

        public static int Amount
        {
            get { return amount; }
            set 
            {
                if (value>=0)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("Amount must greater than 0");
                }
            }
        }

        public bool CanWork
        {
            get 
            {
                if (this.age>=18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
