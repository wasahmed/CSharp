using System;

namespace polymorphism{

    class Cat : Animal{
        public override void AnimalSound()
        {
            Console.WriteLine("meow");
        }
    }
}