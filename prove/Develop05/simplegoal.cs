using System;

public class SimpleGoal : Goal
{
    private List<string> _simpleListOfGoals;
    private string _x;


    public SimpleGoal(string goalName, string goalDescription, string goalAssociatedPoints) : base(goalName, goalDescription, goalAssociatedPoints)
    {
        _simpleListOfGoals = new List<string>();
        _x = "X";
    }

    public override void SetListOfGoal()
    {
        _simpleListOfGoals.Add($"The goals are:\n [{_x}] {_goalName} ({_goalDescription})");
    }


    public override void DisplayListOfGoal()
    {
        foreach(string item in _simpleListOfGoals)
        {
            Console.WriteLine(item);
        }
    }

}