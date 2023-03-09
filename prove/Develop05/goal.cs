using System;
using System.Collections.Generic;

public abstract class Goal
{
    //name of the goal
    protected string _goalName;

    //describes the purpose of the goal
    protected string _goalDescription;

    //set points according to each goal
    protected string _goalAssociatedPoints;

    //stores the total points earned
    private int _totalPoints;

    //holds a list of goals
    //private List<string> _listOfGoals;

    //check if goal is completed
    //private bool _isCompleted;


    public Goal(string goalName, string goalDescription, string goalAssociatedPoints, int totalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAssociatedPoints = goalAssociatedPoints;
        _totalPoints = totalPoints;
        //_listOfGoals = new List<string>();
        //_isCompleted = false;
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


    //set list in different ways in each class
    public abstract void SetListOfGoal();


    //displays the itens in the list in different ways in each class
    public abstract void DisplayListOfGoal();


    public abstract string GetDataToSave();
}