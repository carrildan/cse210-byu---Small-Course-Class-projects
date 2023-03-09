using System;
using System.Collections.Generic;

public class Goal
{
    //name of the goal
    private string _goalName;

    //describes the purpose of the goal
    private string _goalDescription;

    //set points according to each goal
    private string _goalAssociatedPoints;

    //stores the total points earned
    private int _totalPoints;

    //holds a list of goals
    private List<string> _listOfGoals;

    //check if goal is completed
    private bool _isCompleted;


    public Goal(string goalName, string goalDescription, string goalAssociatedPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAssociatedPoints = goalAssociatedPoints;
        _listOfGoals = new List<string>();
        _isCompleted = true;
    }


    //sets the attributes to values the user inputs
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("\nWhat is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("\nWhat is the amount of points associated with this goal? ");
        _goalAssociatedPoints = Console.ReadLine();
    }


    //add to the list the text with name and description of the goal  -------  MAYBE CHANGE THE NAME OF THE METHOD
    public void SetListOfGoal()
    {
        string x;
        if (_isCompleted == true)
        {
            x = "X";
        }else {
            x = " ";
        }
        _listOfGoals.Add($"The goals are:\n [{x}] {_goalName} ({_goalDescription})");
    }


    //displays the itens in the list
    public void DisplayListOfGoal()
    {
        
        foreach(string item in _listOfGoals)
        {
            Console.WriteLine(item);
        }
    }
}