using System;
public class Breathing : Activity
{

    public Breathing(int duration, string title, string description) : base(duration, title, description)
    {

    }
    
    public void BreathingActivity()
    {
        StartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = Timer();
        while (startTime < endTime)
        {
            Console.WriteLine("Breath in");
            Spinner(4);
            Console.WriteLine("Breath out");
            Spinner(4);
            startTime = DateTime.Now;
        }

        EndMessage();
    }
}