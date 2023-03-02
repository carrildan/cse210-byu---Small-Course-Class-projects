using System;


public class Activity
{
    //property for the name of each activity
    private string _activityName = "undefined";
    //property for the description of each activity
    private string _activityDescription = "undefined";
    //property for the duration of each activity. It can be accessed by all Run...Activity methods
    protected int _activityDuration; 


    //constructor to first set attributes
    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _activityDescription = description;
        _activityDuration = duration;
    }


    //displays the common start message
    public void DisplayStartMessage()
    {
        //welcome message and description of the activity
        Console.WriteLine($"Welcome to the {_activityName} activity.\n");
        Console.WriteLine($"{_activityDescription}\n");


        //prompts the user for the time duration of the activity and clear console
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();


        Console.WriteLine("Get ready...");
        //PausingSpinner();
        PausingLoading();
        Console.WriteLine("\n");
    }


    //displays the common end message
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        PausingSpinner();
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName} activity");
        //PausingSpinner();
        PausingLoading();
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


        //display spinner animation
        foreach(string symbol in animationStrings)
        {
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


    //creates a countdown for the activities
    public void PausingCountdown()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


    //creates a loading while program is in pause. For some parts of the program.
    public void PausingLoading()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        List<string> loading = new List<string>(){"L","O","A","D","I","N","G"," "};
        for (int i = 3; i > 0; i--)
            foreach(var item in loading)
            {
                Console.Write(item);
                Thread.Sleep(100);
                if (item == "G")
                    //erase the text when hits G then start over
                    Console.Write("\r" + new string(' ',Console.WindowWidth) + "\r");
            }
    }
}