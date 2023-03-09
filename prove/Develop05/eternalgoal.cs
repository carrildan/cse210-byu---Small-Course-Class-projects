using System;

public class EternalGoal : Goal
{
    private List<string> _eternalListOfGoal;
    public EternalGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _eternalListOfGoal = new List<string>();
    }


    public override void SetListOfGoal()
    {
        _eternalListOfGoal.Add($"The goals are:\n [ ] {_goalName} ({_goalDescription})");
    }


    //overrides method to display from the current list
    public override void DisplayListOfGoal()
    {
        {
            foreach(string item in _eternalListOfGoal)
            {
                Console.WriteLine(item);
            }
        }
    }


    public override string GetDataToSave()
    {
        throw new NotImplementedException();
    }



}