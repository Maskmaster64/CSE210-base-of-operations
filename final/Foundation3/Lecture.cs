using System;
public class Lecture : Event
{
    private string _speaker;
    private int _capacityLimit;

    public Lecture(string speaker, int capacityLimit, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacityLimit = capacityLimit;
    }

    public void FullDetails()
    {
        BasicDetails();
        Console.WriteLine("Event type: Lecture");
        Console.WriteLine($"We will have {_speaker} as a guest speaker.");
        Console.WriteLine($"We will be limited to {_capacityLimit} guests.");
    }
}