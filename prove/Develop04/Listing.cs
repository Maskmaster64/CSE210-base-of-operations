using System;
using System.Reflection.Metadata;
public class Listing : Activity
{
    private List<string> _prompts = new List<string>();

    public Listing(int duration, string title, string description) : base(duration, title, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void ListingActivity()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        StartMessage();
        Spinner(2);
        Console.WriteLine("Your prompt is as follows.");
        Spinner(2);
        Console.WriteLine("");
        Console.WriteLine(_prompts[randomIndex]);
        Spinner(5);
        Console.WriteLine("");
        Console.WriteLine("You will get 10 seconds to think of as many answers as you can.");
        Console.WriteLine("Then write as many answers as you can within the time limit.");
        Spinner(3);
        Console.WriteLine("Ready?");
        CountDown(10);
        Console.WriteLine("Go!");
        
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = Timer();

        while (startTime < endTime)
        {
            string input = Console.ReadLine();
            responses.Add(input);
            Console.WriteLine("");
            startTime = DateTime.Now;
        }
        Console.WriteLine("Done!");

        Spinner(2);
        Console.WriteLine($"You have given a total of {responses.Count} responses");
        Spinner(2);
        EndMessage();


    }
}