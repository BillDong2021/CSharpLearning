using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color="red" };
            AppleBox box1 = new AppleBox() { Cargo = apple };

            Book book = new Book() { Name = "Tom" };
            BookBox box2 = new BookBox() { Cargo = book };

            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }
    }
    
    public class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class AppleBox
    {
        public Apple Cargo { get; set; }
    }
    class BookBox
    {
        public Book Cargo { get; set; }
    }
}
