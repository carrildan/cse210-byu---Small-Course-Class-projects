using System;

public class Receptions : Event
{
    private string _rsvp;


    public Receptions(string eventTitle, string eventDescription, string eventType, string rsvp) : base(eventTitle, eventDescription, eventType)
    {
        _rsvp = rsvp;
    }


    public override void FullDetailsMessage()
    {
        Console.Write($"Full details message:\n{GetType()} event\nTitle: {GetTitle()}\n{GetDescription()}\nDate: {GetDate().ToLongDateString()}\nTime: {GetTime().ToShortTimeString()}pm\nAddress\n{GetAddresses()}");
        
        Console.WriteLine($"Email: {_rsvp}\n");
    }
}