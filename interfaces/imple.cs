using System;
namespace interfaces{

    class Imple : IInterfaceOne, IInterfaceTwo{
        public void methodOne(){
            Console.WriteLine("method one");
        }

        public void methodTwo(){
            Console.WriteLine("method two");
        }
    }
}