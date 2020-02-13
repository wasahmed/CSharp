using System;

namespace methods
{
    class Program
    {
        //Procedural programming is about writing procedures or methods 
        //that perform operations on the data, while object-oriented 
        //programming is about creating objects that contain both data 
        //and methods.
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
