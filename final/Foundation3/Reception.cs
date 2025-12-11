using System;
public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void FullDetails()
    {
        BasicDetails();
        Console.WriteLine("Event type: Reception");
        Console.WriteLine($"RSVP email: {_rsvpEmail}");
    }
}