using System;
using System.Security.Cryptography;

class Program
{
    static int guess,difficulty,random = RandomNumberGenerator.GetInt32(1,100);
    static float points;
    static string player="Guest";
    static void PrintMainScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*    Guess The Number     *");
        Console.WriteLine("***************************");
        Console.WriteLine(" 1. Play");
        Console.WriteLine(" 2. Exit");
        Console.Write(" Select Option: ");
    }

    static void PrintDifficultyScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*    Difficulty Level     *");
        Console.WriteLine("***************************");
        Console.WriteLine(" 1. Easy");
        Console.WriteLine(" 2. Medium");
        Console.WriteLine(" 3. Hard");
        Console.WriteLine(" 4. Back");
        Console.Write(" Select Option: ");
    }

    static void PrintPlayerScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*         Player          *");
        Console.WriteLine("***************************");
        Console.Write(" - Enter Player Name: ");
        string name = Convert.ToString(Console.ReadLine());
        player = name==null?"Guest":name;
    }
    
    static void PrintRuleScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*          Rules          *");
        Console.WriteLine("***************************");
        Console.WriteLine(" - A Random number will be generated from the range 1 to 100.");
        Console.WriteLine($" - You have total {guess} number of guesses to guess the number.");
        Console.WriteLine($" - If you guess the number within the guesses, You will win.");
        Console.WriteLine(" - If can't able to guess the number within the guesses, You will lose.");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static void PlayGameScreen()
    {
        int myGuess;
        PlayGame:
        Console.WriteLine("***************************");
        Console.WriteLine($"* Available Guess: {guess}     *");
        Console.WriteLine("***************************");
        Console.WriteLine(random);
        Console.Write(" Guess the number: ");
        try
        {
            myGuess = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine(" Please Enter Integer Value...");
            goto PlayGame;
        }
        if(myGuess < 0 || myGuess >100)
        {
            Console.WriteLine(myGuess);
            Console.WriteLine(" Please Guess the number from the range 1 to 100...");
            goto PlayGame;
        }
        else if(myGuess > random)
        {
            Console.WriteLine("Please Guess The Smaller Number...");
            guess--;
            goto PlayGame;
        }
        else if(myGuess < random)
        {
            Console.WriteLine("Please Guess The Larger Number...");
            guess--;
            goto PlayGame;
        }
        else
        {
            Console.WriteLine("Congratulations!!!");
            Console.WriteLine($"Attempts Taken: {11-guess}");
            Console.WriteLine($"Total Score: {guess*points}");
        }
    }
    static void Main()
    {
        int choice;
        MainScreen:
        PrintMainScreen();
        try
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("\n Please enter integer\n");
            goto MainScreen;
        }
        switch (choice)
        {
            case 1:
                PlayerScreen:
                PrintPlayerScreen();
                DifficultyScreen:
                PrintDifficultyScreen();
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\n Please enter integer\n");
                    goto DifficultyScreen;
                }
                switch (choice)
                {
                    case 1:
                        guess = 10;
                        difficulty = 1;
                        points = 20.0f;
                        break;
                    case 2:
                        guess = 7;
                        difficulty = 2;
                        points = 25.0f;
                        break;
                    case 3:
                        guess = 5;
                        difficulty = 3;
                        points = 40.0f;
                        break;
                    case 4:
                        goto PlayerScreen;
                    default:
                        Console.WriteLine("\n Please select option from 1 to 4");
                        goto DifficultyScreen;
                }   
                PrintRuleScreen();
                PlayGameScreen();
                break;
            case 2:
                return;
            default:
                Console.WriteLine("\n Please select 1 or 2");
                goto MainScreen;
        }
    }
}