using System;

//responsible for the reflecting activity
public class ListingActivity : Activity
{
    //holds a list for all prompts
    private List<string> _listOfListingPrompts;
    //holds a list for all answers to the prompts
    private List<string> _listOfListingAnswerPrompts;    


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _listOfListingPrompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }
}