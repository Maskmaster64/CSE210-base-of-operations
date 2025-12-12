using System;
public class Swimming : Exercise
{
    private int _laps;

    public Swimming(int laps, string date, int duration) : base(date, duration)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double Speed()
    {
        double speed = Distance() / _duration * 60;
        return speed;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}