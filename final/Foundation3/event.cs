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
    private Addresses _eventAddress;

    //type of the event
    private string _eventType;


    public Event(string eventTitle, string eventDescription, string eventType)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventType = eventType;
    }


    //returns the title of the event 
    public string GetTitle()
    {
        return _eventTitle;
    }


    //returns the description of the vent
    public string GetDescription()
    {
        return _eventDescription;
    }


    //returns the type of the event
    public string GetType()
    {
        return _eventType;
    }


    //returns the date of the event
    public DateTime GetDate()
    {
        return _eventDate;
    }


    //returns the time of the event
    public TimeOnly GetTime()
    {
        return _eventTime;
    }


    //sets the date and time of an event
    public void SetEventDateAndTime(DateTime date, TimeOnly time)
    {
        _eventDate = date;
        _eventTime = time;
    }


    //sets the properties for  _costomerAddress
    public void SetAddresses(string street, string city, string state, string province)
    {
        _eventAddress = new Addresses(street,city,state,province);
    }


     public string GetAddresses()
    {
        return _eventAddress.GetAddresses();
    }


    //displays the standard message
    public void StandardDetailsMessage()
    {
        Console.WriteLine($"\nStandard details message:\nTitle: {_eventTitle}\n{_eventDescription}\nDate: {_eventDate.ToLongDateString()}\nTime: {_eventTime.ToShortTimeString()}pm\nAddress\n{_eventAddress.GetAddresses()}");
    }


    //displays the short description message
    public void ShortDescriptionMessage()
    {
        Console.WriteLine($"Short description message:\n{_eventType} event\nTitle: {_eventTitle}\nDate: {_eventDate.ToLongDateString()}\n");
    }


    //displays the full details message
    public virtual void FullDetailsMessage()
    {
        Console.WriteLine($"Standard details message:\n{_eventType}\nTitle: {_eventTitle}\n{_eventDescription}\nDate: {_eventDate.ToLongDateString()}\nTime: {_eventTime.ToShortTimeString()}pm\nAddress\n{_eventAddress.GetAddresses()}");
    }
}