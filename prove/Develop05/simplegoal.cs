using System;

public class SimpleGoal : Goal
{
    //private List<string> _simpleListOfGoals;
    private string _goalCompletedCheckMark;
    //private bool _isCompleted; // MAYBE DELETE IT AND TURN PROTECTED IN BASE CLASS


    public SimpleGoal(string line) : base(line)
    {
        _goalType = "Simple Goal";
        /*var first = line.Split(":");
        foreach(string word in first)
        {
            if(word == "Simple Goal")
            {
                _goalType = word;
            }
            else if(word == "101")
            {
                _totalPoints = int.Parse(word);
            }
        }*/
      
        
        /*var first = line.Split(":");
        var words = first[0];
        for(int i = 0; i < first.Length; i++)
        {
            if (first[i] == "101")
            {
                _totalPoints = int.Parse(first[i]);
            }
        }*/

        var last = line.Split(",");
        for(int i = 0; i < last.Length; i++)
        {
            if (last[i] == "elisangela")
            {
                _goalName = last[i];
            }
            else if(last[i] == "carril")
            {
                _goalDescription = last[i];
            }
            else if(last[i] == "101")
            {
                _totalPoints = int.Parse(last[i]);
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
        //_simpleListOfGoals.Add($"The goals are:\n [{_goalCompletedCheckMark}] {_goalName} ({_goalDescription})");
        return ($"The goals are:\n [{_goalCompletedCheckMark}] {_goalName} ({_goalDescription})");


    }


    //displays the itens in the list in different ways in each class
    public override void DisplayListOfGoal()
     {
        /*foreach(string item in _simpleListOfGoals)
        {
            Console.WriteLine(item);
        }*/
        Console.WriteLine(GetListOfGoal());
    }


    //return a string to save object
    public override string Save()
    {
       return ($"{_goalName},{_goalDescription},{_goalAssociatedPoints},{_isCompleted}");
    }
}