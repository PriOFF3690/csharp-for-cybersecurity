using System;

class Program
{
    static void Main()
    {
        // This is a single line comment
        /*
            And this is a muptiline comment.
            comments don't compile or executes, so if you want to save a comment in the code for notes or information, you can save it like this.
            This improves readiness of the program and helps you and other developers working on your project, as they can be guided through comments.
        */

        // Talking about the identifiers, they are just a name, you give to the Variables, Methods, Classes, and Labels.
        // They are used to identify these elements in a program

        // Declaring & initializing a variable 
        int x = 19; // Here, x is a variable. 

        // Syntax for declaring a varible
        // <datatype> <identifier>; 
        
        // Syntax for declaring and initializing a variable
        // <datatype> <identifier> = <value>;  

        /* 
            Variables: 
                - A container that creates a space in a memory to store the data.
                - variable's values can be changed thoughout the program.
                - You must define Datatype to tell the compiler which type of values you will gonna store inside the variable.

            DataType:
                - A datatype is nothing but the actual type of the value you store inside the variable.
                - Example: interger value, decimal value, etc.
                Type of Datatypes inm csharp
                - Value Data Types
                    -> int          : stores integer values
                    -> flaot        : stores floating points
                    -> double       : stores long flaoring points
                    -> char         : stores single characters
                    -> bool         : stores boolean values (True / False)
                
                - Reference Data Types
                    -> string       : A Sequence of characters. They are immutable, meaning their value cannnot be changed after creation.
                    -> object       : The base type of all data types in C#. It can store values of any type using boxing. It provides flexibility when working with different data types.
                    -> array        : Used to store multiple values of the same datatype. Elements are stored in contiguous memory locations. It allows efficient access using index.
                
                - Pointer Data Types
                    -> pointer      : Used to store the memory address of a variable. Pointer types require the use of unsafe code to access and modify memory directly.

        */
        
        // Value Data Types
        int a = 10;
        float b = 11.3f;
        double c = 34.23;
        char d = 'a';
        bool e = true;

        // Reference Data Types
        string f = "This is a simple string";
        object g = 10; // Boxing
        int[] h = {1,2,3,4};

        // Pointer Data Types
        unsafe
        {
            
            int i = 10;
            int* j = &i; // j is a pointer of i
            Console.WriteLine("i: "+i);
            Console.WriteLine("j: "+ *j );

        }

        // Printing variables
        Console.WriteLine("a: "+a);
        Console.WriteLine("b: "+b);
        Console.WriteLine("c: "+c);
        Console.WriteLine("d: "+d);
        Console.WriteLine("e: "+e);
        Console.WriteLine("f: "+f);
        Console.WriteLine("g: "+g);
        Console.WriteLine("h: {"+h[0]+", "+h[1]+", "+h[2]+", "+h[3]+"}");    
    }
}