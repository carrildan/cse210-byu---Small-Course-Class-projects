using System;

//responsible for the reflecting activity
public class ListingActivity : Activity
{
    //holds a list for all prompts
    private List<string> _listOfListingPrompts;
    //holds a list for all answers to the prompts
    private List<string> _listOfListingAnswerPrompts;    
    //holds a single prompt
    private string _prompt;
    //holds a single answer to the prompt
    private string _answer;


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _listOfListingPrompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }


    //return a single prompt
    public string GetListingPrompt()
    {
        return $"{_prompt}";
    }


    //sets a single prompt
    public void SetListingPrompt()
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(0, _listOfListingPrompts.Count);
        string rndWord = _listOfListingPrompts[rndIndex];

        _prompt = rndWord;
    }


    public string GetListingAnswersOfPrompt()
    {
        return ($"{_answer}");
    }


    public void SetListingAnswersOfPrompt()
    {
        _answer = Console.ReadLine();
    }


    public void DisplayListingPrompt()
    {
        Console.WriteLine($"--- {_prompt} ---");
    }


    public void DisplayListingOfAofPrompt()
    {
        Console.WriteLine($"> {_answer}");
    }


    public void RunListingActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        DisplayListingPrompt();
        
        Console.Write("You may begin in: ");
        PausingCountdown();

        DateTime StartTime = DateTime.Now;
        DateTime Endtime = StartTime.AddSeconds(_activityDuration);

        while(DateTime.Now < Endtime)
        {
            Console.Write("\n> ");
            SetListingAnswersOfPrompt();
        }
    }
}