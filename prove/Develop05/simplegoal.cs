using System;

public class SimpleGoal : Goal
{
    //private List<string> _simpleListOfGoals;
    private string _goalCompletedCheckMark;
    //private bool _isCompleted; // MAYBE DELETE IT AND TURN PROTECTED IN BASE CLASS


    public SimpleGoal(string line) : base(line)
    {
        _goalType = "Simple Goal";
    }

    public SimpleGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        //_simpleListOfGoals = new List<string>();
        _goalCompletedCheckMark = " ";
        //_isCompleted = true;
        _goalType = "Simple Goal";
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
        return ($"{_goalType}:{_goalName},{_goalDescription},{_goalAssociatedPoints},{_isCompleted}");
    }
}