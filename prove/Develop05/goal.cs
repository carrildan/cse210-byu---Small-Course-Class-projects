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
        //specifies the type for this goal
        _goalType = "Simple Goal";

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
        }    
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


    //set list in different ways in each class
    public abstract string GetListOfGoal();


    //should return total points (UNDER DEVELOPMENT)
    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    //displays the itens in the list in different ways in each class
    public abstract void DisplayListOfGoal();


    //return text format to save as a file
    public abstract string Save();


    //load a file
    public static List<Goal> Load(string file)
    { 
        string[] lines = System.IO.File.ReadAllLines(file);
        var list = new List<Goal>();

        for(int i = 1; i < lines.Length; i++)
        //foreach(string line in lines)
        {
            var goalType = "Simple";
            switch(goalType) {
                case "Simple": list.Add(new SimpleGoal(lines[i]));
                break;
                /*
                case "Eternal": list.Add(new EternalGoal(lines));
                break;

                case "CheckList": list.Add(new EternalGoal(line));
                break;*/

                default: break;
            }
        }
        return list;      
    }


     /*split between goal type and goal content | split between goal name, description and associated points |
     also displays the goals that are inside a file */
    /*public void DisplayListOfGoalInFile(string file)
     {
        string[] parts;
        string first = " ";
        string second = " ";
        string[] lines = System.IO.File.ReadAllLines(file);
        for(int i = 1; i < lines.Count();i++)
        {
            //split between goal type and content
            parts = lines[i].Split(":");
            first = parts[0];
            second = parts[1];

            //split between goal name, descrition and points
            string[] secondparts = second.Split(",");
            _goalName = secondparts[0];
            _goalDescription = secondparts[1];
            _goalAssociatedPoints = secondparts[2];

            Console.WriteLine($"The goals are:\n [{" "}] {_goalName} ({_goalDescription} {_goalAssociatedPoints})");
        }
    }*/


    /*record an event
    public void RecordEvent()
    {
        Console.WriteLine($"1. {_goalName}");
        //string fileLoaded = DisplayListOfGoalInFile();
    }*/
}