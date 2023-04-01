using System;

public class OutdoorGatherings : Event
{
    //holds a weather condition
    private string _weather;


    public OutdoorGatherings(string eventTitle, string eventDescription, string eventType, string weather) : base(eventTitle, eventDescription, eventType)
    {
        _weather = weather;
    }


    public override void FullDetailsMessage()
    {
        Console.WriteLine($"Full details message:\n{GetType()} event\nTitle: {GetTitle()}\n{GetDescription()}\nDate: {GetDate().ToLongDateString()}\nTime: {GetTime().ToShortTimeString()}pm\nAddress\n{GetAddresses()}");
        
        Console.WriteLine($"Weather forecast: {_weather} all day.\n");
    }
}