using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("TOM");
            Console.WriteLine(stu.Name);
        }
    }
    class Student
    {
        public Student(string initName)
        {
            if(!string.IsNullOrEmpty(initName))
            {
                this.Name = initName;
            }
            else
            {
                throw new ArgumentException("initName cannot be null or empty");
            }
        }
        public string Name;
    }

}
