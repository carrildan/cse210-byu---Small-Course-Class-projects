using System;

//responsible for the reflecting activity
public class ReflectingActivity : Activity
{
    //attributes to hold reflecting activity´s prompts and questions
    private List<string> _listOfReflectingPrompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _listOfReflectingQofPrompts = new List<string>();


    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    
    }


    //get random prompts
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(0,_listOfReflectingPrompts.Count); 
        string rndPrompt = _listOfReflectingPrompts[rndIndex];

        return rndPrompt;

    }
}