using System;

class Program
{
    static void Main()
    {
        // Exceptions are runtime errors in a program, which violate system constraints. 
        // For example, when the program attempts to divide a number by zero, an exception occurs. 
        // When an exception occurs, the system catches it and raises the exception.

        /*
            To handle exceptions, you use the try...catch statement:
            try
            {
                // statements to be guarded for exceptions
            }
            catch(ExeceptionType e)
            {
                // exception handler

            }
            Code language: C# (cs)
            In this syntax:
                - First, place the statements that you want to guard for exceptions in the try block.
                - Second, provide the exception handler in the catch block to handle the exception.
            When an exception occurs in the try block, the control of the program immediately jumps to the catch block.
        */

        try
        {
            Console.Write("Enter any integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+ " x 10 = "+ (a*10));
        }
        catch(Exception e)  // if you enter anything except integer it will show error.
        {
            // Console.WriteLine("Error: "+ e); 
            Console.WriteLine("Error: Please Enter Integer");
            Console.WriteLine(e);
        }
        finally // 'finally' is optional. The flow control will be gone through finally block, from try and catch both.
        {
            Console.WriteLine("This is finally block");
        }
    }
}