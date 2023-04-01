using System;

public class Event
{
    //title of an event
    private string _eventTitle;

    //description of an event
    private string _eventDescription;

    //date of the event
    private DateTime _eventDate;

    //time of an event
    private TimeOnly _eventTime;

    //address for an event
    //private Address _eventAddress;

    //type of the event
    private string _eventType;


    public Event(string eventTitle, string eventDescription, string eventType)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventType = eventType;
    }


    //sets the date and time of an event
    public void SetEventDateAndTime(DateTime date, TimeOnly time)
    {
        _eventDate = date;
        _eventTime = time;
    }


    //displays the standard message
    public void StandardDetailsMessage()
    {
        Console.WriteLine($"Standard details message:\nTitle: {_eventTitle}\n{_eventDescription}\nDate: {_eventDate.ToLongDateString()}\nTime: {_eventTime.ToShortTimeString()}pm\n");
    }


    //displays the short description message
    public void ShortDescriptionMessage()
    {
        Console.WriteLine($"Short description message:\n{_eventType}\nTitle: {_eventTitle}\nDate: {_eventDate.ToLongDateString()}\n");
    }


    //displays the full details message
    public void FullDetailsMessage()
    {
        
    }
}