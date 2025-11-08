using System;
using System.Net;
public class Reflection : Activity
{
    private List<string> _scenarios = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(int duration, string title, string description) : base(duration, title, description)
    {
        _scenarios.Add("Think of a time when you stood up for someone else.");
        _scenarios.Add("Think of a time when you did something really difficult.");
        _scenarios.Add("Think of a time when you helped someone in need.");
        _scenarios.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
    }

    public void ReflectionActivity()
    {
        Random random = new Random();
        int randomScenario = random.Next(_scenarios.Count);
        
        StartMessage();
        Spinner(3);
        Console.WriteLine("Here is your scenario.");
        Spinner(1);
        Console.WriteLine(_scenarios[randomScenario]);
        Spinner(3);
        Console.WriteLine("Answer as many questions you can before the time runs out.");


        DateTime startTime = DateTime.Now;
        DateTime endTime = Timer();
        bool endOfActivity = false;
        while (endOfActivity == false)
        {
            int i = 0;
            TimeSpan pausedTimer = endTime.Subtract(startTime);
            while (startTime < endTime)
            {
                if (i != 0)
                {
                    Console.WriteLine("Ok, lets go to the next question.");
                    Spinner(3);
                    Console.WriteLine("");
                    endTime = startTime.Add(pausedTimer);
                }
                i++;
                int randomQuestion = random.Next(_questions.Count);
                Console.WriteLine(_questions[randomQuestion]);
                Console.ReadLine();
                startTime = DateTime.Now;

                // ensures we don't get a negitive paused timer
                if (startTime < endTime)
                {
                    pausedTimer = endTime.Subtract(startTime);
                }

                Console.WriteLine("Lets pause for a moment.");
                Spinner(5);

            }
            endOfActivity = true;

            EndMessage();
        }

    }
}
