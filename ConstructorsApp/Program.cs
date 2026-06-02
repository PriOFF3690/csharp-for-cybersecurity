using System;
using System.Diagnostics;
/*
    A constructor in C# is a special method of a class that is automatically called when an object of the class is created. 
    It has the same name as the class, does not have a return type and is mainly used to initialize the object's data members.

    A class can define multiple constructors (constructor overloading).
    A constructor cannot be virtual or abstract. Only a special kind of constructor can be static.
    
    Types of Constructor:
        1. Default Constructor
        2. Parameterized Constructor
        3. Copy Constructor
        4. Private Constructor
        5. Static Constructor

    1. Default Constructor:    
        A default constructor in C# is a constructor with no parameters. It is automatically provided by the compiler if no constructor is defined in the class. It initializes numeric fields to 0, Boolean to false and reference types like strings or objects to null

    2. Parameterized Constructor:
        A constructor having at least one parameter is called a parameterized constructor. It can initialize each instance of the class to different values.

    3. Copy Constructor:
        A copy constructor is used to create a new object by copying values from an existing object of the same class. In C#, copy constructors are not built-in and must be explicitly defined by the user.

    4. Private Constructor:
        If a constructor is created with a private specifier is known as Private Constructor. It is not possible for other classes to derive from this class and also it’s not possible to create an instance of this class. Some important points regarding the topic is mentioned below:
            - A private constructor is often used in implementing the Singleton design pattern, but it does not implement the pattern by itself.
            - Use a private constructor when we have only static members.
            - Using a private constructor prevents the creation of the instances of that class.

        Note: Access modifiers can be used in constructor declaration to control its access i.e. which other class can call the constructor. Private Constructor is one of it's example.
    
    5. Static Constructor:
        Static Constructor has to be invoked only once in the class and it has been invoked during the creation of the first reference to a static member in the class. A static constructor is used to initialize static fields or data of a class and is executed only once.

            - It can’t be called directly.
            - When it is executing then the user has no control.
            - It does not take access modifiers or any parameters.
            - It is called automatically to initialize the class before the first instance is created.

*/

class Shape
{
    private float width, legth;

    // Default Constructor
    public Shape()
    {
        width = 0;
        legth = 0;
    }

    // Parameterized Constructor
    public Shape(float w, float l)
    {
        this.width = w;
        this.legth = l;
    }

    // Copy Constructor
    public Shape(Shape obj)
    {
        this.width = obj.width;
        this.legth = obj.legth;
    }
    public float getArea()
    {   
        return this.width*this.legth;
    }
}

class MyClass
{
    // Private constructor: objects cannot be created. of this class.
    private MyClass(){
        Console.WriteLine("from private connstructor");
    }

    public static void printMessage()
    {
        Console.WriteLine("\nThis is a statis method inside MyClass");
    }

}

class Demo
{
    // Static Constructor: It is invoked before the first instance constructor is run.
    static Demo()
    {
        Console.WriteLine("\nThis is static constructor");
    }
    public Demo()
    {
        Console.WriteLine("This is default constructor");
    }
    public Demo(string message)
    {
        Console.WriteLine("Message: "+message);
    }
}
class Program
{
    static void Main()
    {
        Shape s1 = new Shape();             // calling default constructor
        Shape s2 = new Shape(2.3f, 2.3f);   // Parameterized constructor
        Shape s3 = new Shape(s2);           // calling copy constructor
    
        Console.WriteLine("Area of s1: "+s1.getArea());
        Console.WriteLine("Area of s2: "+s2.getArea());
        Console.WriteLine("Area of s3: "+s3.getArea());

        // The below line will display an error.
        // MyClass t1 = new MyClass();
        MyClass.printMessage(); 

        Demo d1 = new Demo();
        Demo d2 = new Demo("Parameterized constructor of Demo class");

    }
}