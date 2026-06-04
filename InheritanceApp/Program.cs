using System;

/*
    Inheritance:
        It in C# is an object-oriented programming (OOP) feature that allows one class to derive properties and behaviors from another class. 
        It promotes code reusability, extensibility and establishes a natural hierarchical relationship between classes.

        class BaseClass {
            // Members of base class
        }

        class DerivedClass : BaseClass {
            // Members of derived class
        }

    Inheritance is achieved using the : (colon) symbol.
    Derived Class: The class that inherits the other class is known as a subclass ( or a derived class, extended class or child class).
    Parent Class: The class whose features are inherited is known as a superclass (or a base class or a parent class).
    C# supports single inheritance (a class can directly inherit from only one class).
    A derived class can itself serve as a base for another class.
    All classes in C# implicitly inherit from the System.Object class.

    Types of Inheritance:
        C# directly supports the following inheritance forms:

        - Single Inheritance: One class derives from one base class.
        - Multilevel Inheritance: A class derives from another derived class.
        - Hierarchical Inheritance: Multiple classes derive from a single base class.
        - Multiple Inheritance (Through Interfaces): A class can implement multiple interfaces, achieving multiple inheritance indirectly, since C# does not allow multiple base classes.
*/


// Here, Human -> Person = Simple Inheritance
class Human
{
    protected int legs=2, hands=2;
}

class Person:Human
{
    string name;
    int age;
    public Person(string name,int age)
    {
        this.name = name;
        this.age = age;
    }
    public void showInfoPerson()
    {
        Console.WriteLine("Person name: "+name);
        Console.WriteLine("Person age: "+age);
        Console.WriteLine("Hands: "+this.hands);
        Console.WriteLine("Legs: "+this.legs);

    }
}

// Here, GrandFather -> Father -> Son = multiple inheritance
class GrandFather
{
    protected void showInfoGrandFather()
    {
        Console.WriteLine("I am a grandfather");
    }
}

class Father: GrandFather
{
    protected void showInfoFather()
    {
        showInfoGrandFather();
        Console.WriteLine("I am a father");
    }
}

class Son: Father
{
    public void showInfoSon()
    {
        showInfoFather();
        Console.WriteLine("I am a son");
    }
}



// Here (Shape -> Square) and  (Shape -> Rectangle) forms Hierarchical Inheritance 
class Shape
{
    protected float length,width;
    
}

// Shape -> Square
class Square:Shape
{
    public Square(float x)
    {
        this.length = x;
        this.width = x;
    }
    public void printArea()
    {
        Console.WriteLine("Area of Square: "+(this.length*this.width));
    }
}

// Shape -> Rectangle
class Rectangle : Shape
{
    public Rectangle(float x,float y)
    {
        this.length = x;
        this.width = y;
    }
    public void printArea()
    {
        Console.WriteLine("Area of rectangle: "+(this.length*this.width));
    }
}

class Program
{
    static void Main()
    {
        // Simple Inheritance
        Console.WriteLine("\nSimple Inheritance:");
        Person p1 = new Person("John",21);
        p1.showInfoPerson();

        // Multi-level Inheritance
        Console.WriteLine("\nMulti-level Inheritance:");
        Son s1 = new Son();
        s1.showInfoSon();

        // Hierchical Inheritance
        Console.WriteLine("\nHierchical Inheritance:");
        Square sq1 = new Square(5);
        sq1.printArea();

        Rectangle re1 = new Rectangle(4,5);
        re1.printArea();
    }

}