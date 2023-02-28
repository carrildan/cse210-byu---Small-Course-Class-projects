using System;


public class BreathingActivity : Activity
{
    //attributes to hold breathing text
    private string _breathIn;
    private string _breathOut;


    public BreathingActivity(string breathIn, string breathOut, string name, string description, int duration) : base(name, description, duration)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }


    //for breath in message
    public string GetBreathInMessage()
    {
        return ($"{_breathIn}");
    }


    //for breath out message
    public string GetBreathOutMessage()
    {
        return ($"{_breathOut}");
    }


    public void DisplayBreathMessage()
    {
        Console.Write($"{GetBreathInMessage()}");
        PausingCountdown();

        Console.Write($"\n{GetBreathOutMessage()}");
        PausingCountdown();


    }
}