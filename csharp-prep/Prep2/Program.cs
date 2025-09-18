using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you get in class? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string LetterGrade;
        if (grade >= 90)
        {
            LetterGrade = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            LetterGrade = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            LetterGrade = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            LetterGrade = "D";
        }
        else
        {
            LetterGrade = "F";
        }
        if (LetterGrade == "A" || LetterGrade == "F")
        {
            Console.WriteLine($"You got an {LetterGrade}");
        }
        else
        {
            Console.WriteLine($"You got a {LetterGrade}");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations, you passed the class");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class");
        }

    }
}