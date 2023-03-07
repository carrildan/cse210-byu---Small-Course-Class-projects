using System;

public abstract class Goal
{
    //name of the goal
    private string _goalName;
    //describes the purpose of the goal
    private string _goalDescription;
    //set points according to each goal
    private int _goalAssociatedPoints;


    public Goal(string goalName, string goalDescription, int goalAssociatedPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAssociatedPoints = goalAssociatedPoints;
    }


    public virtual void CreateGoal()
    {
        
    }
}