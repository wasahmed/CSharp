using System;
using classes;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.Color = "blue";
            Console.WriteLine(obj.Color);
        }
    }
}
