using System;
namespace abstraction{
    abstract class Animal{
        public abstract void animalSound();
        public void sleep(){
            Console.WriteLine("zzZzZz");
        }
    }
}
//To access the abstract class, it must be inherited from another class.