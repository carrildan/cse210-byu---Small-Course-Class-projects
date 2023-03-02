using System;

//responsible for the reflecting activity
public class ListingActivity : Activity
{
    //holds a list for all prompts
    private List<string> _listOfListingPrompts;
    //holds a list for all answers to the prompts
    //private List<string> _listOfListingAnswerPrompts;    TO DO: UNNECESSARY. TAKE IT OFF AFTER 100% COMPLETE.

    //stores quantity of answers provided by the user
    private int items;
    //holds a single prompt
    private string _prompt;
    //holds a single answer to the prompt
    private string _answer;   // TO DO: MAYBE IS UNCESSARY. TAKE IT OFF AFTER 100% COMPLETE.


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _listOfListingPrompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }


    //return a single prompt
    public string GetListingPrompt()
    {
        return $"{_prompt}";
    }


    //sets a single random prompt
    public void SetListingPrompt()
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(0, _listOfListingPrompts.Count);
        string rndWord = _listOfListingPrompts[rndIndex];

        _prompt = rndWord;
    }


    //returns an answer set in the setter
    public string GetListingAnswersOfPrompt()
    {
        return _answer;
    }


    //prompts the user for an answer and add answer as a item
    public void SetListingAnswersOfPrompt()
    {
        _answer = Console.ReadLine(); 
        items += 1;
    }


    //displays the prompt question
    public void DisplayListingPrompt()
    {
        Console.WriteLine($" --- {_prompt} ---");
    }


    /*public void DisplayListingOfAofPrompt()
    {
        Console.WriteLine($">{GetListingAnswersOfPrompt()}");    TO DO: MAYBE IS UNNECESSARY. TAKE IT OFF AFTER 100% COMPLETE.
    }*/


    //runs the activity by calling its methods
    public void RunListingActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        SetListingPrompt();
        DisplayListingPrompt();
        
        Console.Write("You may begin in: ");
        PausingCountdown();
        Console.Write("\n");

        DateTime StartTime = DateTime.Now;
        DateTime Endtime = StartTime.AddSeconds(_activityDuration);

        //keep letting user type entries until activity time is up
        while(DateTime.Now < Endtime)
        {
            Console.Write("> ");
            SetListingAnswersOfPrompt();
        }
        Console.WriteLine($"You listed {items} items \n");
    }
}