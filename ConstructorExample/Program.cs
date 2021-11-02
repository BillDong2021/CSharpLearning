using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStu = new Student(2,"Tom");
            Console.WriteLine(myStu.Name);
            Console.WriteLine(myStu.ID);
            Console.WriteLine("-------------------------");
            Student myStu2 = new Student();
            Console.WriteLine(myStu2.Name);
            Console.WriteLine(myStu2.ID);
        }
    }
    class Student
    {
        public Student(int initID,string initName)
        {
            this.ID = initID;
            this.Name = initName;
        }
        public Student()
        {
            this.ID = 1;
            this.Name = "No name";
        }
        public int ID;
        public string Name;
    }
}
