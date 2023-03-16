using System;

public class EternalGoal : Goal
{
    private List<string> _eternalListOfGoal;

    
    public EternalGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _eternalListOfGoal = new List<string>();
    }


    //set list in different ways in each class
    public override void AddListOfGoal()
    {
        _eternalListOfGoal.Add($"The goals are:\n [ ] {_goalName} ({_goalDescription})");
    }


    //displays the itens in the list in different ways in each class
    public override void DisplayListOfGoal()
    {
        {
            foreach(string item in _eternalListOfGoal)
            {
                Console.WriteLine(item);
            }
        }
    }


    //return text format to save as a file
    public override string Save()
    {
        return ($"Eternal Goal:{_goalName},{_goalDescription},{_goalAssociatedPoints},{_isCompleted}");
    }
}