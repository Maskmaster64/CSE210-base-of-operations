using System;
using System.Data;

public class Activity
{
    private int _duration;
    private string _title;
    private string _description;

    public Activity(int duration, string title, string description)
    {
        _duration = duration;
        _title = title;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_title} Activity.");
        Console.WriteLine("");
        Thread.Sleep(1000);
        Console.WriteLine(_description);
    }

    public void EndMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_title} Activity.");
        Console.WriteLine("");
    }

    public void Spinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(700);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }

        // foreach (string s in animation)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
    }

    public DateTime Timer()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        return endTime;

        // bool timesUp = false;

        // while (timesUp == false)
        //     if (DateTime.Now >= endTime)
        //     {
        //         Console.WriteLine("Times up");
        //         timesUp = true;
        //     }

        // return timesUp;
    }
    
    public void CountDown(int count)
    {
        for (int i = count; i > 0; i--)
        {
            if (i >= 10)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b\b");
            }
            else
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
                
        }
    }
}