using System;

public class CheckListGoal : Goal
{
    //bonus for completing a goal
    private int _bonusPoints;

    //bonus associated with each goal
    private int _goalAssociatedBonus;

    //sets the amount of goals that must be accomplished
    private int _eternalGoalCount;

    //counts the amount of goals has been accomplished
    private int _eternalGoalCompletedCount;

    //stores the check list goals
    //private List<string> _checkListOfGoals;

    //checks when goal is accomplished
    private string _goalCompletedCheckMark;
  
    public CheckListGoal(string line) : base(line)
    {
        _goalType = "CheckList Goal";
        //specifies the type for this goal
        

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
            _eternalGoalCount = int.Parse(last[4]);
            
        }    
    }

    public CheckListGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _goalCompletedCheckMark = " ";
        _isCompleted = false;
        _goalType = "CheckList Goal";
    }


    //overrides virtual method to add more prompts
    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("\nWhat is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("\nWhat is the amount of points associated with this goal? ");
        _goalAssociatedPoints = Console.ReadLine();

        Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
        _eternalGoalCount = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
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
        return ($"[{_goalCompletedCheckMark}] {_goalName} ({_goalDescription}) -- Currently completed: {_eternalGoalCompletedCount}/{_eternalGoalCount}"); 
    }


    //displays goal different ways in each class
    public override void DisplayGoal()
    {
        Console.WriteLine(GetGoal());
    }


    //return a string with data to save object
    public override string Save()
    {
        return ($"{_goalType}:{_goalName},{_goalDescription},{_goalAssociatedPoints},{_bonusPoints},{_eternalGoalCount},{_eternalGoalCompletedCount}");
    }


    //record an event
    public override void RecordEvent(int user)
    {
        if(user == 3)
        {        
            _totalPoints += int.Parse(_goalAssociatedPoints);
            DisplayCompletedGoalMessage();
            _eternalGoalCompletedCount += 1;

            //when user reaches goals count it marks as completed
            if(_eternalGoalCompletedCount == _eternalGoalCount)
            {
                _totalPoints += _bonusPoints;
                _isCompleted = true;
            }
        }
    }

    

}