using System;
public class Cycling : Exercise
{
    private int _speed;

    public Cycling(int speed, string date, int duration) : base(date, duration)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        double distance = _speed * _duration;
        return distance;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}