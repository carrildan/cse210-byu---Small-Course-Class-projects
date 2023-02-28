using System;


public class BreathingActivity : Activity
{
    //attributes to hold breathing text
    private string _breathIn;
    private string _breathOut;
    private int _actDuration;


    public BreathingActivity(string breathIn, string breathOut, string name, string description, int duration) : base(name, description, duration)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
        _actDuration = duration;
    }


    //for breath in message
    public string GetBreathInMessage()
    {
        return ($"{_breathIn}");
    }


    //for breath out message
    public string GetBreathOutMessage()
    {
        return ($"\n{_breathOut}");
    }


    public void DisplayBreathMessage()
    {
        Console.Write($"{GetBreathInMessage()}");
        PausingCountdown();


        Console.Write($"{GetBreathOutMessage()}");
        PausingCountdown();
        Console.WriteLine("\n");

    }


    public void RunBreathingActivity()
    {
        DateTime StartTime = DateTime.Now;
        DateTime Endtime = StartTime.AddSeconds(20);
        while (DateTime.Now < Endtime)
            DisplayBreathMessage();
    }
}