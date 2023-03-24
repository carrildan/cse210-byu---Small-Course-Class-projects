using System;

public class EternalGoal : Goal
{
    //private List<string> _eternalListOfGoal;

     public EternalGoal(string line) : base(line)
    {
        _goalType = "Eternal Goal";
    }

    public EternalGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _goalType = "Eternal Goal";

        //_eternalListOfGoal = new List<string>();
    }


    //set list in different ways in each class
    public override string GetListOfGoal()
    {
        //_eternalListOfGoal.Add($"The goals are:\n [ ] {_goalName} ({_goalDescription})");
        return ($"[ ] {_goalName} ({_goalDescription})");
    }


    //displays the itens in the list in different ways in each class
    public override void DisplayListOfGoal()
    {
        Console.WriteLine(GetListOfGoal());
    }


    //return text format to save as a file
    public override string Save()
    {
        return ($"{_goalType}:{_goalName},{_goalDescription},{_goalAssociatedPoints},{_isCompleted}");
    }
}