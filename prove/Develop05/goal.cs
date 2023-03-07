using System;

public class Goal
{
    //name of the goal
    private string _goalName;
    //describes the purpose of the goal
    private string _goalDescription;
    //set points according to each goal
    private int _goalAssociatedPoints;
    //stores the total points earned
    private int _totalPoints;
    //holds a list of goals
    private List<string> _listOfGoals;
    //check if goal is completed
    private bool _isCompleted;


    public Goal(string goalName, string goalDescription, int goalAssociatedPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAssociatedPoints = goalAssociatedPoints;
    }


    //sets the properties of the goal
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("\nWhat is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("\nWhat is the amount of points associated with this goal? ");
        string user = Console.ReadLine();
        _goalAssociatedPoints = int.Parse(user);
    }


    public string GetListOfGoal()
    {
        string x;
        if (_isCompleted == true)
        {
            x = "X";
        }else
        {
            x = " ";
        }

        return ($"[{x}] {_goalName} ({_goalDescription})");
    }
}