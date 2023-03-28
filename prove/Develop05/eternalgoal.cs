using System;

public class EternalGoal : Goal
{
     public EternalGoal(string line) : base(line)
    {
        //specifies the type for this goal
        _goalType = "Eternal Goal";   

        //stores the right side of the split(name, description etc)
        var second = "";

        //stores the left side of the split(type)
        var firstSplit = line.Split(":");
        
        foreach(string word in firstSplit)
        {
            _goalType = firstSplit[0];
            second = firstSplit[1];
        }

        var last = second.Split(",");
        for(int i = 0; i < last.Length; i++)
        {
            _goalName = last[0];
            _goalDescription = last[1];
            _goalAssociatedPoints = last[2];
        }    
    }

    public EternalGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _goalType = "Eternal Goal";
    }


    //returns a goal (it never ends, so it does not check with x mark)
    public override string GetGoal()
    {
        //_eternalListOfGoal.Add($"The goals are:\n [ ] {_goalName} ({_goalDescription})");
        return ($"[ ] {_goalName} ({_goalDescription})");
    }


    //displays goal different ways in each class
    public override void DisplayGoal()
    {
        Console.WriteLine(GetGoal());
    }


    //return a string with data to save object
    public override string Save()
    {
        return ($"{_goalType}:{_goalName},{_goalDescription},{_goalAssociatedPoints}");
    }


    //record an event
    public override void RecordEvent(int user)
    {
        if(user == 2)
        {        
            _totalPoints += int.Parse(_goalAssociatedPoints);
            DisplayCompletedGoalMessage();
        }
      
    }


    
}