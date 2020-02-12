using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            static int MyMethod(int a){
                int result = a * 2;
                return result;
            }
            Console.WriteLine(MyMethod(2));
        }
    }
}
