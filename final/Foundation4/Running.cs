using System;
using System.Runtime.CompilerServices;
public class Running : Exercise
{
    private double _distance;

    public Running(double distance, string date, int duration) : base(date, duration)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double speed = (_distance / _duration) * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _duration / _distance;
        return pace;
    }
}