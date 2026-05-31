using System;

class Program
{
    static void Main()
    {
        /*
            Looping: 
                Looping in a programming language is a way to execute a statement or a set of statements multiple times, depending on the result of the condition to be evaluated to execute statements. 
                The result condition should be true to execute statements within loops.

            Types of loops:
            1. while
            2. do..while
            3. for
        */

        /*
            11. while Loop : The test condition is given at the beginning of the loop and all statements are executed till the given Boolean condition is satisfied. When the condition becomes false, the control will be out of the while loop.

            Syntax:
            while (boolean condition)
            {
                loop statements...
            }
        */
        Console.Write("While Loop:\n");
        int i = 1;
        while (i < 10)
        {
            Console.Write(i+", ");
            i+=1;
        }

        /*
            2. do-while loop : The do while loop is similar to while loop with the only difference that it checks the condition after executing the statements, i.e it will execute the loop body one time for sure because it checks the condition after executing the statements.

            Syntax :
            do
            {
                statements..
            } while (condition);

        */
        i = 1;
        Console.WriteLine("\nDo While Loop");
        do
        {
            Console.Write(i+", ");
        }while(i>10);

        /*
            3. for loop : The for loop is a control flow statement that allows you to execute a block of code repeatedly for a fixed number of iterations. It’s commonly used when the number of repetitions is known beforehand.

            Syntax:
            for (loop variable initialization ; testing condition; increment / decrement)
            {    
                // statements to be executed
            }
        */
        Console.WriteLine("\nFor Loop");
        for ( i = 0; i < 10; i++)
        {
            Console.Write(i+", ");
        }
    }
}