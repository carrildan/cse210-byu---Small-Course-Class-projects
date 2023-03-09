using System;

public class EternalGoal : Goal
{
    private List<string> _eternalListOfGoal;
    public EternalGoal(string goalName, string goalDescription, string goalAssociatedPoints) : base(goalName, goalDescription, goalAssociatedPoints)
    {
        _eternalListOfGoal = new List<string>();
    }


    public override void SetListOfGoal()
    {
        _eternalListOfGoal.Add($"The goals are:\n [ ] {_goalName} ({_goalDescription})");
    }


    public override void DisplayListOfGoal()
    {
        {
            foreach(string item in _eternalListOfGoal)
            {
                Console.WriteLine(item);
            }
        }
    }



}