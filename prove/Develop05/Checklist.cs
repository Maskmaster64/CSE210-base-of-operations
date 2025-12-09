using System;
public class Checklist : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _completeBonus;

    public Checklist(string title, string description, bool isComplete, int points, int timesToComplete, int timesCompleted, int completeBonus) : base(title, description, isComplete, points)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _completeBonus = completeBonus;
    }

    public override void CompleteGoal()
    {
        if (_timesCompleted == _timesToComplete)
        {
            _isComplete = true;
        }

        else
        {
            _isComplete = false;
        }
    }
}