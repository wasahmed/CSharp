

namespace classes
{
    public class Car{
        //Did you notice the public keyword? It is called an access 
        //modifier, which specifies that the color variable/field 
        //of Car is accessible for other classes as well, such as Program.
        private string color = "red";

        //A constructor is a special method that is used to initialize
        // objects. The advantage of a constructor, is that it is called
        // when an object of a class is created. It can be used to set initial values for fields
    //    public  Car(){
    //        this.color = "color";
    //    }

       public string Color{
           get {return color;}
           set {color = value;}
       }
    

    }
}

