using System;
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void BasicDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Join us on {_date} at {_time}");
        Console.WriteLine($"Located at {_address}");
        Console.WriteLine(_description);
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event type: {GetType().Name}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}