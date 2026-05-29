using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main()
    {
        // Operators allows to perform multiple types of operations upon operands
        // Operands are the variables on which can perform operations.
        // Operations are the actions perform on the operands which provides results as their output.

        // Exmaple: a + b, Here a & b are the operands, while + is an operator for addition operation.
        // We have multiple types of Operators in csharp.
         
        /*
            Types of operator
            1. Arithmetic Operators
            2. Relational Operators
            3. Logical Operators
            4. Assignment Operators
            5. Increment and Decrement Operators
            6. Bitwise Operators
            7. Ternary Operator
            8. Null Coalescing Operator
        */

        /* 
            1. Arithmentic Operators: Arithmetic operators are used to perform basic mathematical operations on numeric values.
                Addition ( + )
                Subtraction ( - )
                Multiplication ( * )
                Division ( / )
                Modulus ( % )
        */
        int a = 10;
        int b = 3;
        Console.WriteLine("Variable a = "+a);
        Console.WriteLine("Variable b = "+b);
        Console.WriteLine("\n/** Arithmetic Operators: **/");
        Console.WriteLine("a + b = "+(a+b));
        Console.WriteLine("a - b = "+(a-b));
        Console.WriteLine("a * b = "+(a*b));
        Console.WriteLine("a / b = "+(a/b));
        Console.WriteLine("a % b = "+(a%b));

         /* 
            2. Relational Operators: Relational operators are used to compare values. And we get the answer in either true or false ( boolean).
                Equal to ( == )
                Not equal to ( != )
                Less than ( < )
                Less than or equal to ( <= )
                greater than ( > )
                Greater than or equal to ( >= )
        */

        Console.WriteLine("\n/** Relational Operators: **/");
        Console.WriteLine("a == b = "+(a==b));
        Console.WriteLine("a != b = "+(a!=b));
        Console.WriteLine("a < b = "+(a<b));
        Console.WriteLine("a > b = "+(a>b));
        Console.WriteLine("a <= b = "+(a<=b));
        Console.WriteLine("a >= b = "+(a>=b));

        /* 
            3. Logical Operators: Used when multiple conditions and there we can combine these to compare complex conditions.

                Logical AND (&&) : returns true when both conditions are true.
                Logical OR ( || ) : returns true if at least one condition is true.
                Logical NOT ( ! ): returns true when a condition is false and vice-versa
        */
        bool c = true,d=false,e=true;
        Console.WriteLine("\nBoolean c = "+c);
        Console.WriteLine("Boolean d = "+d);
        Console.WriteLine("Boolean e = "+e);
        Console.WriteLine("\n/** Logical Operators: **/");
        Console.WriteLine("c && d = "+(c && d));
        Console.WriteLine("c || d = "+(c || d));
        Console.WriteLine("!c = "+(!c));

        /* 
            4. Assignment Operators: Assignment operators are used to assign values to variables. The assignment operator is combined with others to create shorthand compound statements. Common compound operators include:

                += (Add and assign.)
                -= (Subtract and assign.)
                *= (Multiply and assign.)
                /= (Divide and assign.)
                %= (Modulo and assign.)
        */

        int f = 10;
        Console.WriteLine("\nint f = "+f);
        Console.WriteLine("\n/** Assignment Operators: **/");
        Console.WriteLine("f += 10 = "+ (f+=10));
        Console.WriteLine("f -= 10 = "+ (f-=10));
        Console.WriteLine("f *= 10 = "+ (f*=10));
        Console.WriteLine("f /= 10 = "+ (f/=10));
        Console.WriteLine("f %= 10 = "+ (f%=10));

        /* 
            5. Increment/Decrement Operators: Increment and decrement operators are used to increase or decrease the value of a variable by 1.

                ++ (Increments by 1)
                    Post-Increment: Uses value first, then increments.
                    Pre-Increment: Increments first, then uses value.
                    
                -- (Decrements by 1)
                    Post-Decrement: Uses value first, then decrements.
                    Pre-Decrement: Decrements first, then uses the value.
        */
        int g = 3;
        Console.WriteLine("\nint g = "+g);
        Console.WriteLine("\n/** Increment/Decrement Operators: **/");
        Console.WriteLine("++g = "+ (++g));
        Console.WriteLine("g++ = "+ (g++));
        Console.WriteLine("Final value of g: " + g);
        Console.WriteLine("\n--g = "+ (--g));
        Console.WriteLine("g-- = "+ (g--));
        Console.WriteLine("Final value of g: " + g);

        /* 
            6. Bitwise Operators: Bitwise operators are used to perform bit-level operations on integer values. It takes less time because it directly works on the bits.
        */
         // Binary representation: 1010
        int x = 10;
        // Binary representation: 0010
        int y = 2;

        Console.WriteLine("\nint x = "+x);
        Console.WriteLine("int y = "+y);
        Console.WriteLine("\n/** Bitwise Operators: **/");
        Console.WriteLine("x & y = " + (x & y));    // Bitwise AND 
        Console.WriteLine("x | y = " + (x | y));    // Bitwise OR  
        Console.WriteLine("x ^ y = " + (x ^ y));    // Bitwise XOR
        Console.WriteLine("~x = " + (~x));          // Bitwise NOT 
        Console.WriteLine("x << 1 = " + (x << 1));  // Shifting bit by one on the left
        Console.WriteLine("x >> 1" + (x >> 1));     // Shifting bit by one on the right

        /* 
            7. Ternary Operator: The ternary operator is a shorthand for an if-else statement. It evaluates a condition and returns one of two values depending on whether the condition is true or false.

            Syntax: 
                condition ? if true : if false 
        */

        int h = 10, i = 5;
        // similar to if else
        Console.WriteLine("\nint h = "+h);
        Console.WriteLine("int i = "+i);

        Console.WriteLine("\n/** Ternary Operators: **/");
        string result = (h > i) ? "h" : "i";
        Console.WriteLine("(h > i) = "+result + " is greater");
    
        /* 
            8. Null-Coalescing Operator: The null-coalescing operator (??) is used to provide a default value when a variable is null.
        */
        string j = null;
        Console.WriteLine("\n(null) string j = "+ j);
        // If name is null, use "Default Name"
        string k = j ?? "Default Value of null string";

        Console.WriteLine("\n/* Null-Coalescing Operator */");
        Console.WriteLine("string k = "+ k);
    }
}