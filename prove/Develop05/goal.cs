using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalType;
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


    public Goal(string line)
    {
        
    }

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

        Console.WriteLine($"\nYou have {GetTotalPoints()} points.\n");
    }


    //returns a goal
    public abstract string GetGoal();


    //should return total points (UNDER DEVELOPMENT)
    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    //displays goal different ways in each class
    public abstract void DisplayGoal();


    //return a string with data to save object
    public abstract string Save();


    //load a file and separate it into different types of goal
    public static List<Goal> Load(string file)
    { 
        string[] lines = System.IO.File.ReadAllLines(file);
        var list = new List<Goal>();

        var goalType = "";
        for(int i = 1; i < lines.Length; i++)       
        {            
            //gets the type of goals and add a new goal according to its type
            var spliting = (lines[i].Split(":"));
            goalType = spliting[0];
                      
                switch(goalType) {
                    case "Simple Goal": list.Add(new SimpleGoal(lines[i]));
                    break;
                    
                    case "Eternal Goal": list.Add(new EternalGoal(lines[i]));
                    break;

                    case "CheckList Goal": list.Add(new CheckListGoal(lines[i]));
                    break;

                    default: break;
            }
        }
        return list;      
    }


    //displays the name of the goals in a file
    public void GetGoalName()
    {
        Console.WriteLine($"{_goalName}");
    }


    //record an event
    public void RecordEvent()
    {        
        //Console.WriteLine("Which goal did you acomplish? ");
    }
}