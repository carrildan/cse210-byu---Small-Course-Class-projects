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


    public string GetBreathInMessage()
    {
        return ($"{_breathIn}");
    }
}