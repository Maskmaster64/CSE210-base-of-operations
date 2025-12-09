using System;
public class Eternal : Goal
{
    public Eternal(string title, string description, bool isComplete, int points) : base(title, description, isComplete, points)
    {
        
    }

    public override void CompleteGoal()
    {
        _isComplete = false;
    }
}