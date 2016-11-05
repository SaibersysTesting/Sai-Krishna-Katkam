using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Constructor of Base Class");
        }
        public void DisplayMessage()
        {
            Console.WriteLine("Hello, how are you?");
        }
    }

    public class Child : Base
    {
        public Child()
        {
            Console.WriteLine("Constructor of Child class");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Child objChild = new Child();
            //Child class don't have DisplayMessage() method but we inherited from "Base" class
            objChild.DisplayMessage();
            Console.Read();
        }
    }
}
