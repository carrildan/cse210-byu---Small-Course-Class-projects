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
    protected int _totalPoints;

    //holds a list of goals
    //private List<string> _listOfGoals;

    //check if goal is completed
    protected bool _isCompleted;


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


    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    //displays the itens in the list in different ways in each class
    public abstract void DisplayListOfGoal();


    //displays the itens in the file
    public void DisplayListOfGoalInFile()
    {
        // TOD DO: IMPLEMENTAR - CAN BE USED TO LIST THE CONTENT OF A FILE
    }


    //return text as should appear when saved as a file
    public abstract string Save();


    //load a file
    public string Load(string file)
    { 
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines)
        {
            return line;
        }
        return"";         
    }


    public void GoalFromFile()
    {
        string first = " ";
        string second = " ";
        string[] lines = System.IO.File.ReadAllLines("teste.txt");
        for(int i = 1; i < lines.Count();i++)
        {
            string[] parts = lines[i].Split(":");
            first = parts[0];
            second = parts[1];
            Console.WriteLine($"{first} {second}");
        }
    }

}