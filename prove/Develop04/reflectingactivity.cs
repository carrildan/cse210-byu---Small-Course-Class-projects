using System;

//responsible for the reflecting activity
public class ReflectingActivity : Activity
{
    //attributes to hold reflecting activity´s prompts and questions
    private List<string> _listOfReflectingPrompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _listOfReflectingQofPrompts = new List<string>(){"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    private string _prompt;
    private string _question;



    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    
    }


    //returns a prompt
    public string GetRandomPrompt()
    {
        return ($"Consider the following prompt:\n\n--- {_prompt} ---");
    }


    //get a single random prompt and set it as attribute´s value
    public void SetRandomPrompt()
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(0,_listOfReflectingPrompts.Count); 
        string rndPrompt = _listOfReflectingPrompts[rndIndex];

        _prompt = rndPrompt;
    }


    //returns the question about the prompt
    public string GetRandomQonPrompt()
    {
        return ($"{_question}");
    }


    //gets a single random question and set it as the attribute´s value
    public void SetRandomQonPrompt()
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(0,_listOfReflectingQofPrompts.Count); 
        string rndQuestion = _listOfReflectingQofPrompts[rndIndex];

        _question = rndQuestion;
    }
}