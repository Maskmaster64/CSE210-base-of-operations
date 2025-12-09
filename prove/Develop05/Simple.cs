using System;
public class Simple : Goal
{
    public Simple(string title, string description, bool isComplete, int points) : base(title, description, isComplete, points)
    {
        
    }

    public override void CompleteGoal()
    {
        _isComplete = true;
    }
}