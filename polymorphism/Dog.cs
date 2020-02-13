using System;

namespace polymorphism{

    class Dog : Animal{
        public override void AnimalSound(){
            Console.WriteLine("woof");
        }
    }
}