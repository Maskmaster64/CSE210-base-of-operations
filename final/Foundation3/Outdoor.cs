using System;
public class Outdoor : Event
{
    private string _forcast;

    public Outdoor(string forcast, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _forcast = forcast;
    }

    public void FullDetails()
    {
        BasicDetails();
        Console.WriteLine("Event type: Outdoor gathering");
        Console.WriteLine($"Weather forcast: {_forcast}");
    }
}