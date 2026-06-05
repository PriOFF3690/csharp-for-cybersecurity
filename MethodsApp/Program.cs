using System;

// Method Overriding:
// Multiple methods with the same name, same parameters, same return type. (in different classes).
// virtual keyword is used to define function for method overriding
// override keyword id used to declare function for n
class Demo
{
    public virtual void printMessage()
    {
        Console.WriteLine("This is Demo class");
    }
}

class ChildDemo : Demo
{
    public override void printMessage()
    {
        Console.WriteLine("This is ChildDemo class");
    }
}

class Program
{

    // Method Overloading:
    // Multiple functions with the same name; (return type & parameters) can be different
    static int add(int i,int j)
    {
        return i+j;
    }
    static int add(int i,int j,int k)
    {
        return i+j+k;
    }
    public static void Main()
    {
        // method overloading
        Console.WriteLine("\nMethod Overloading:");
        Console.WriteLine("add(1,4): "+add(1,4));
        Console.WriteLine("add(1,4,4): "+add(1,4,4));

        // Method overriding
        Console.WriteLine("\nMethod Overriding:");
        ChildDemo c1 = new ChildDemo();
        c1.printMessage();

        // Function parameters
        // Value Parameter
        Console.WriteLine("\n\nValue Parameters");
        int a =5;
        Console.WriteLine("a = "+a);
        Increment(a);
        Console.WriteLine("After increment a = "+a);

        // ref Parameter
        Console.WriteLine("\n\nRef Parameters");
        string name = "John";
        Console.WriteLine("Before update name = "+name); // Cat
        Update(ref name);
        Console.WriteLine("After update name = "+name); // Cat

        // out Parameter
        Console.WriteLine("\n\nout Parameters");
        int b;
        Update(out b);
        Console.WriteLine("b = "+b);
        
        // Default Parameters
        Console.WriteLine("\n\nDefault Parameters");
        print();
        print("This is the parameter");

        // named Parameters
        Console.WriteLine("\n\nNamed Parameters");
        ShowDetails(age: 32,name: "John");

        // Params Parameters
        Console.WriteLine("\n\nParams Parameters");
        Console.WriteLine("Multiply(1,2,3): ");
        multiply(1,2,3);
        Console.WriteLine("Multiply(1,2,3,4,5): ");
        multiply(1,2,3,4,5);
    }

    // Parameters type in a function:
    // Function parameters in C# are variables defined in a method that receive values when the method is called. They allow you to pass data into methods and use it inside the method.

    /*
        1. Value Parameters:
            Value parameters pass a copy of the variable’s data to the method. Any changes made inside the method do not affect the original variable.  

        2. Ref Parameters:
            The ref keyword passes arguments by reference, allowing the called method to modify the original variable's value.
            Rules:
                - The variable must be initialized before passing to ref.
                - Changes made inside the method reflect in the calling scope.

        3. Out Parameters
            The out keyword is used to pass parameters by reference, mainly to return multiple values from a method.
            Rules:
                - The variable need not be initialized before passing.
                - The method must assign a value before returning.

        4. In Parameters
            The in keyword passes arguments by reference but does not allow modification inside the method.

        5. Default (Optional) Parameters
            Optional parameters allow you to omit arguments when calling a method. Each optional parameter has a default value, which is used when no argument is provided.
            Rules:
                - Must be defined after all required parameters.
                - Can be omitted at the time of the call.

        6. Named Parameters
            Named parameters allow you to pass arguments by specifying the parameter names, instead of relying on their order. It was introduced in C# 4.0.
        
        7. Params Parameters
            The params keyword allows a method to accept a variable number of arguments of the same type
            Rules:
                - Only one params parameter is allowed per method.
                - Must be the last parameter in the definition.
    */
    // Value parameter
    static void Increment(int a)
    {
        a++;        
    }
    // Ref Parameter
    static void Update(ref string text)
    {
        if (text == "Dog")
            Console.WriteLine("Matched!");
        text = "Cat";
    }
    // out Parameter
    static void Update(out int b)
    {
        b = 10;
    }
    // defualt parameter
    static void print(string message = "This is defualt message")
    {
        Console.WriteLine("Message: "+message);
    }
    // Named Parameter
    static void ShowDetails(string name,int age)
    {
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
    }
    // Params Parameter
    static void multiply(params int[] numbers)
    {
        int result=1;
        foreach(int n in numbers)
        {
            result*=n;
        }
        Console.WriteLine("Result = "+result);
    }
}