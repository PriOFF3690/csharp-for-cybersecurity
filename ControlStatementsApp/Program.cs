using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Control Statements are the statements which decides the flow of your program.
        /*
            Decision Making:
            1. if statement
            2. if-else statement
            3. if-else-if ladder
            4. nested if
            5. switch
            6. nested switch
        */

        // 1. if statement: if the condition is true only then the block of code executes
        // Syntax:
        // if (condition) {
        //      statements...
        // }
        if (1 == 1)
        {
            Console.WriteLine("1 == 1 is true");
        }

        /*
            2. if-else statement: if the condition is true then only if block executes, else the 'else' block will be executed.
            Syntax:
            if (condition) {
            
            } 
            else{
            
            } 
        */
        if (1 == 2)
        {
            Console.WriteLine("1==2 is false");
        }
        else
        {
            Console.WriteLine("Else block is executed because the condition was false");
        }

        /*
            3. if-else-if ladder: A repeatative blocks of if-else-if block mentioned with condition. else block is optional here.
            Syntax:
            if (condition) {
            
            } 
            else if (condition){
            
            } 
            ...
            else {
            
            }
        */
        if (1 == 2)
        {
            Console.WriteLine("1==2 is true");
        }
        else if (1 == 3)
        {
            Console.WriteLine("1==2 is true");
        }
        else if (1 == 1)
        {
            Console.WriteLine("1==1 is true"); // you can add more else if as much as you want. It's not neccessary to put else block at the end.
        }
        else
        {
            Console.WriteLine("All conditions are false, so else block executed.");
        }

        /*
            4. nested if: When a block if 'if statement' is used inside another 'if statement' its called nested if. 
            Syntax:
            if (condition) {
                if (condition){
                
                }else{
                
                }
            } 
            else{
                if(condition){
                
                }
            }
            
        */
        if (1 == 1)
        {
            if (1 == 3)
            {
                Console.WriteLine("1st nested if executed");
            }
            else
            {
                Console.WriteLine("else statement is executed in 1st if");
            }
        }
        else
        {
            Console.WriteLine("else executed");
        }

        /*
           5. switch: 
           - Switch statement is an alternative to long if-else-if ladders. 
           - The expression is checked for different cases and the one match is executed. Break Statement is used to move out of the switch. 
           - If the break is not used, the control will flow to all cases below it until break is found or switch comes to an end. 
           - There is default case (optional) at the end of switch, if none of the case matches then default case is executed.
. 
           Syntax:
           switch (expression)
           {
                   case value1: // statement sequence
                   break;
                   case value2: // statement sequence
                   break;
                   .
                   .
                   .
                   case valueN: // statement sequence
                   break;
                   default: // default statement sequence
           }    
       */
        char a = 'a';
        switch (a)
        {
            case 'b':
                Console.WriteLine("character is b");
                break;
            case 'a':
                Console.WriteLine("character is b");
                break;
            default:
                Console.WriteLine("Default statement executed");
                break;
        }

        /*
            6. Nested Switch: Nested Switch case are allowed in C# . In this case, switch is present inside other switch case. Inner switch is present in one of the cases in parent switch.
        */
        bool b = true;
        bool c = false;
        switch (b)
        {
            case true:
                Console.WriteLine("b is true");
                switch (c)
                {
                    case true:
                        Console.WriteLine("c is true");
                        break;
                    case false:
                        Console.WriteLine("c is false");
                        break;
                    default:
                        Console.WriteLine("Default inside b=true");
                        break;
                }
                break;
            case false:
                Console.WriteLine("b is false");
                switch (c)
                {
                    case true:
                        Console.WriteLine("c is true");
                        break;
                    case false:
                        Console.WriteLine("c is false");
                        break;
                    default:
                        Console.WriteLine("Default inside b=false");
                        break;
                }
                break;
            default:
                Console.WriteLine("This is default statement");
                break;
        }
    }
}