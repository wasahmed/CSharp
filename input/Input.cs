using System ;//means that we can use classes from the System namespace;

namespace input //is a used to organize your code, and it is a container for classes and other namespaces.
{
    class Input
    //is a container for data and methods, which brings functionality to 
    //your program. Every line of code that runs in C# must be inside a
    // class. In our example, we named the class Input.
    {
        static void Main(string[] args)
        {
            double my = 5.99D;
            Console.WriteLine(my);
            Console.WriteLine("Enter name");
            string name =Console.ReadLine();
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("your name is " + name +" and your age is " + age);
            Console.WriteLine($"your name is {name}");// string interpolation
            int day = 40;
                switch (day) 
                {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("not found");
                    break;
                }

            for (int i = 0; i < 5; i++) 
            {
            Console.WriteLine(i);
            }

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
            Console.WriteLine(i);
            }

            int z = 0;
                while (z < 10) 
                {
                    if (z == 4) 
                    {
                    z++;
                    continue;
                    }
                    Console.WriteLine(z);
                    z++;
            // It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):
        }
    }
            }   
}
