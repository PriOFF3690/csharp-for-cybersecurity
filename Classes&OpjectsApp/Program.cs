using System;
using System.Security.Cryptography.X509Certificates;

/*
    Class:
        A class is a user-defined data type that encapsulates data and behavior. It can contain fields, properties, methods, events, and constructors. 
        A class itself does not occupy memory until its objects are created.

        Syntax:
        class ClassName{
            // Fields
            // Properties
            // Methods
        }

        Declaration of Class:
            A class declaration begins with the class keyword followed by the class name. However, some optional attributes can be used with class declaration according to the application requirement. Class declarations can include these components, in order:

            - Modifiers: Define the accessibility of a class. By default, a class is internal.
            - Keyword class: Used to declare a class.
            - Class Identifier: The name of the class, conventionally starting with a capital letter.
            - Base Class (Optional): Specifies a parent class to inherit from, using the : symbol.
            - Interfaces (Optional): A comma-separated list of interfaces implemented by the class, also preceded by : A class can implement multiple interfaces.
            - Body: Enclosed within { }, containing members like fields, properties, methods, constructors and events
*/
public class Dog  
{
    int age;
    string name, breed, color;

    /*
        Constractor: 
            - It is a special method inside a class. 
            - Constrator has same name as class, whenever object of the class is created, the respective class's constructor called itself automatically.
            - It has no return value. 
            - Construtor must be public.
            - It is mainly used for object initialization.
    */
    public Dog(String name, string breed, int age, string color)
    {
        this.name = name;  // By 'this' keyword we are referring the current running object. 
        this.breed = breed; // 'this.breed' means the currrent object's 'breed' member (variable); also, only 'breed' is actually referring the method parameters.
        this.age = age;
        this.color = color;
    }

    public void makeSound()
    {
        Console.WriteLine(name+" is barking");
    }
}

class Program
{
    static void Main()
    {
        /*
            In Object-Oriented Programming, classes and objects are fundamental concepts used to represent real-world concepts and entities.

            A class is a blueprint used to create objects with similar properties and behaviors.
            An object is an instance of a class.

        */

        /*
            Objects:
            An object in C# is something you create from a class, which represents a real-world entity and lets you use the data and actions defined in that class.

            In C# an object consists of:

            State: It is represented by attributes of an object and reflects the properties of an object.
            Behavior: It is represented by the methods of an object and also reflects how an object interacts with other objects.
            Identity: It represents the unique reference of an object, which distinguishes it from other objects.
            Note: Classes define the blueprint of state, behavior and identity. Objects are the real instances that actually hold the state, show behavior and carry identity.
        */
        Dog myDog = new Dog("Rocky","papillon",5,"white");
        myDog.makeSound();
    }
}