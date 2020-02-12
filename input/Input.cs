using System;

namespace input
{
    class Input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name =Console.ReadLine();
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("your name is " + name +" and your age is " + age);
        }
    }
}
