using System;
using System.Security.Cryptography;

class Program
{
    static int guess,difficulty,random = RandomNumberGenerator.GetInt32(1,100),totalGuess;

    static bool win = false;
    static float points;
    static string player="Guest";

    static void ClearHistory()
    {
        File.WriteAllText("history.txt","");
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*       Clear History     *");
        Console.WriteLine("***************************");
        Console.WriteLine("History has been clear...");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();

    }
    static void PrintMainScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*    Guess The Number     *");
        Console.WriteLine("***************************");
        Console.WriteLine(" 1. Play");
        Console.WriteLine(" 2. History");
        Console.WriteLine(" 3. Clear History");
        Console.WriteLine(" 4. Exit");
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

    static void PrintHistoryScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine("*         History         *");
        Console.WriteLine("***************************");
        using (StreamReader reader = new StreamReader("history.txt"))
        {
            string history = reader.ReadToEnd();
            Console.WriteLine(history);
        }
        Console.Write("\n Press any key to continue...");
        Console.ReadKey();
    }

    static void PrintEndScreen()
    {
        if (win)
        {
            Console.WriteLine($"\nCongratulations, {player}!!!");
            Console.WriteLine($"Attempts Taken: {totalGuess-guess}");
            Console.WriteLine($"Total Score: {guess*points}");
            Console.Write("Enter any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"\nYou lose, {player}!!!");
            Console.WriteLine($"The Random Number Was: {random}");
            Console.WriteLine("Better Luck Next Time...");
            Console.Write("Enter any key to continue...");
            Console.ReadKey();
        }
        LogResult();
    }

    static void LogResult()
    {
        string difficultyString;
        if (difficulty==1)
        {   
            difficultyString = "Easy";
        }
        else if (difficulty == 2)
        {
            difficultyString = "Medium";
        }
        else
        {
            difficultyString = "Hard";
        }
        File.AppendAllText("history.txt",$"{player}\tAttempt Taken: {totalGuess-guess}\tDifficulty: {difficultyString}\tTotal Score: {guess*points}\tTime: {DateTime.Now}\tRandom Number: {random}\n");
        
    }
    static void PlayGameScreen()
    {
        int myGuess;
        PlayGame:
        Console.WriteLine("\n");
        Console.WriteLine("***************************");
        Console.WriteLine($"* Available Guess: {guess}     *");
        Console.WriteLine("***************************");
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
        if(guess == 1)
        {
            guess--;
            PrintEndScreen();
            return;
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
        else if(myGuess == random)
        {
            guess--;
            win=true;
            PrintEndScreen();
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
                        guess  = 10;
                        totalGuess  = 10;
                        difficulty = 1;
                        points = 20.0f;
                        break;
                    case 2:
                        guess = 7;
                        totalGuess = 7;
                        difficulty = 2;
                        points = 25.0f;
                        break;
                    case 3:
                        guess = 5;
                        totalGuess = 5;
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
                PrintHistoryScreen();
                goto MainScreen;
            case 3:
                ClearHistory();
                goto MainScreen;
            case 4:
                return;
            default:
                Console.WriteLine("\n Please select option from 1 to 4");
                goto MainScreen;
        }
        goto MainScreen;
    }
}