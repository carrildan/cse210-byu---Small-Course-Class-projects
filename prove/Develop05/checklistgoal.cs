using System;

public class CheckListGoal : Goal
{
    //bonus for completing a goal
    private int _bonusPoints;

    //bonus associated with each goal
    private int _goalAssociatedBonus;

    //sets the amount of goals that must be accomplished
    private int _checkListGoalCompletedCount;

    //counts the amount of goals has been accomplished
    private int _checkListGoalCount;

    //stores the check list goals
    private List<string> _checkListOfGoals;

    //checks when goal is accomplished
    private string _x;
  
    //returns true if goal is completed so it marks x check
    private bool _isCompleted;


    public CheckListGoal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints) : base(goalName, goalDescription, goalAssociatedPoints, totalPoints)
    {
        _checkListOfGoals = new List<string>();
        _x = " ";
        _isCompleted = true;
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
        _checkListGoalCount = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }


    //overrides method to accomodate more info in the text
    public override void SetListOfGoal()
    {
        if (_isCompleted == true)
        {
            _x = "X";
        }
        else
        {
            _x = " ";
        }
        _checkListOfGoals.Add($"The goals are:\n [{_x}] {_goalName} ({_goalDescription}) -- Currently completed: {_checkListGoalCompletedCount}/{_checkListGoalCount}");
    }


    //overrides method to display from the current list
    public override void DisplayListOfGoal()
    {
        foreach(string item in _checkListOfGoals)
        {
            Console.WriteLine(item);
        }
    }


    //return a string to save object
    public override string GetDataToSave()
    {
        return ($"Checklist Goal: {_goalName},{_goalDescription},{_goalAssociatedPoints},{_totalPoints},{_checkListGoalCount},{_checkListGoalCount}");
    }

}