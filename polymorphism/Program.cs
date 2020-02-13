using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.AnimalSound();
            myDog.AnimalSound();
            myCat.AnimalSound();
        }
    }
}
