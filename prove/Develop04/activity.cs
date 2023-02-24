using System;


class Activity
{
    //property for the name of each activity
    private string _activityName;
    //property for the description of each activity
    private string _activityDescription;
    //property for the duration of each activity
    private int _activityDuration; 


    //constructor to first set attributes
    public Activity()
    {
        _activityName = "undefined";
        _activityDescription = "undefined";
        _activityDuration = 0;
    }


    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
    }

}