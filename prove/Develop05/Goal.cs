using System;
public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected bool _isComplete;
    protected int _points;

    public Goal(string title, string description, bool isComplete, int points)
    {
        _title = title;
        _description = description;
        _isComplete = isComplete;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        Console.WriteLine($"Congradulation, you have earned {_points} points.");
        CompleteGoal();
        return _points;
    }

    public abstract void CompleteGoal();

}