using System;

public class Lectures : Event
{
    //holds the name of a speaker
    private string _speakerName;

    //holds the capacity for an event
    private int _capacity;


    public Lectures(string eventTitle, string eventDescription, string eventType, string speakerName, int capacity) : base(eventTitle, eventDescription, eventType)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }


    public override void FullDetailsMessage()
    {
        Console.WriteLine($"Full details message:\n{GetType()} event\nTitle: {GetTitle()}\n{GetDescription()}\nDate: {GetDate().ToLongDateString()}\nTime: {GetTime().ToShortTimeString()}pm\nAddress\n{GetAddresses()}");
        
        Console.WriteLine($"Speaker: {_speakerName}\nEvent capacity: {_capacity} people");
    }
}