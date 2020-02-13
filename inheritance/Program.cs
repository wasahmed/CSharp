using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.brand);
            Console.WriteLine(myCar.model);
            myCar.hoot();
        }
    }
}
