using System;
namespace Console_asks_you
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter Your First Name");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please enter Your Last Name");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Helllllooooo {0}, {1}", Firstname, Lastname);

        }
    }
}
