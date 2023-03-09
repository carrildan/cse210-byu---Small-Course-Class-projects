using System;

public class SimpleGoal : Goal
{
    private List<string> _simpleListOfGoals;
    private string _x;
    private bool _isCompleted;


    public SimpleGoal(string goalName, string goalDescription, string goalAssociatedPoints) : base(goalName, goalDescription, goalAssociatedPoints)
    {
        _simpleListOfGoals = new List<string>();
        _x = " ";
        _isCompleted = true;
    }

    public override void SetListOfGoal()
    {
        if (_isCompleted == true)
        {
            _x = "X";
        }
        else
        {
            _x = " ";
        }
        _simpleListOfGoals.Add($"The goals are:\n [{_x}] {_goalName} ({_goalDescription})");
    }

    //overrides method to display from the current list
    public override void DisplayListOfGoal()
    {
        foreach(string item in _simpleListOfGoals)
        {
            Console.WriteLine(item);
        }
    }

}