using System;

public class SimpleGoal : Goal
{
    private string _goalCompletedCheckMark;
    //private bool _isCompleted; // MAYBE DELETE IT AND TURN PROTECTED IN BASE CLASS


    public SimpleGoal(string line) : base(line)
    {
        //specifies the type for this goal
        _goalType = "Simple Goal";
        
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

    public SimpleGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _goalCompletedCheckMark = " ";
        //_isCompleted = true;
        _goalType = "Simple Goal";

    }


    //returns a goal
    public override string GetGoal()
    {
        //checks with "X" if goal is completed
        if (_isCompleted == true)
        {
            _goalCompletedCheckMark = "X";
        }
        else
        {
            _goalCompletedCheckMark = " ";
        }
        
        return ($"[{_goalCompletedCheckMark}] {_goalName} ({_goalDescription})");
    }


    //displays goal different ways in each class
    public override void DisplayGoal()
    {
        Console.WriteLine(GetGoal());
        //Console.WriteLine($"You have {GetTotalPoints()} points.\n");
    }


    //return a string with data to save object
    public override string Save()
    {
        return ($"{_goalType}:{_goalName},{_goalDescription},{_goalAssociatedPoints},{_isCompleted}");
    }


    //record an event
    public override void RecordEvent()
    {
        
                
            _totalPoints += int.Parse(_goalAssociatedPoints);
            DisplayCompletedGoalMessage();
            _isCompleted = true;
        
    }


    
}