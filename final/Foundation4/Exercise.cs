using System;
public abstract class Exercise
{
    protected string _date;
    protected int _duration;

    public Exercise(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public void Summary()
    {
        Console.WriteLine($"{_date} {GetType().Name} ({_duration} min)- Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km");
    }
}