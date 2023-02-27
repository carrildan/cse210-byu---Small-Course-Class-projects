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


    //displays the start message
    public void DisplayStartMessage()
    {
        //welcome message and description of the activity
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine($"{_activityDescription}\n");


        //prompts the user for the time duration of the activity
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
    }


    //displays the end message
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} activity");
    }


    //creates a spinner to load while program is paused
    public void PausingSpinner()
    {
        //forms a spinner
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        //message that appears above the spinner for all activities
        Console.WriteLine("Get ready...");


        //display spinner animation
        foreach(string symbol in animationStrings)
        {
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


    public void PausingCountdown()
    {
        
    }



}