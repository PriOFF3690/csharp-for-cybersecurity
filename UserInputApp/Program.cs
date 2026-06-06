using System;

class Program
{
    static void Main()
    {
        String name;
        Console.Write("Enter Your Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Your name: "+name);

        // To take input of the desired datatype use typecasting to convert the datatype.
        Console.Write("\nEnter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Age: "+age);
    }
}