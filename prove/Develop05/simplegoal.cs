using System;

public class SimpleGoal : Goal
{
    //private List<string> _simpleListOfGoals;
    private string _goalCompletedCheckMark;
    //private bool _isCompleted; // MAYBE DELETE IT AND TURN PROTECTED IN BASE CLASS


    public SimpleGoal(string line) : base(line)
    {
        _goalType = "Simple Goal";
        var first = line.Split(":");
        
        foreach(string word in first)
        {
            if(word == "Simple Goal")
            {
                _goalType = word;
            }
            else if(word == "10")
            {
                _totalPoints = int.Parse(word);
            }
            else if(word == "daniel")
            {
                _goalName = word;
            }
        }

        var last = line.Split(",");
        for(int i = 1; i < last.Length; i++)
        {
            if(last[i] == "carril")
            {
                _goalDescription = last[i];
            }
            else if(last[i] == "10")
            {
                _totalPoints = int.Parse(last[i]);
            }
            else if(last[i] == "daniel")
            {
                _goalName = last[i];
            }
        }    
    }

    public SimpleGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        //_simpleListOfGoals = new List<string>();
        _goalCompletedCheckMark = " ";
        //_isCompleted = true;
    }


    //set list in different ways in each class
    public override string GetListOfGoal()
    {
        
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


    //displays the itens in the list in different ways in each class
    public override void DisplayListOfGoal()
     {
        Console.WriteLine(GetListOfGoal());
        //Console.WriteLine($"You have {GetTotalPoints()} points.\n");
    }


    //return a string to save object
    public override string Save()
    {
       return ($"Simple Goal:,{_goalName},{_goalDescription},{_goalAssociatedPoints},{_isCompleted}");
    }
}