using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();


        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);


        DisplayResult(userName, squaredNumber, birthYear);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }


    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string Username = Console.ReadLine();


        return Username;
    }


    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());


        return number;
    }


    static void PromptUserBirthYear(out int BirthYear)
    {
        Console.Write($"What was the year you were born? ");
        BirthYear = int.Parse(Console.ReadLine());


    }


    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;


    }

    static void DisplayResult(string UserName, int square, int BirthYear)
    {
        Console.WriteLine($"Your name is {UserName}, and your number squared is {square}.");
        Console.WriteLine($"This year, You will turn {2025 - BirthYear} years old.");

        
    }

    


}