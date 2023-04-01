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
}