public class Journal
{
    //member variables. list for questions creation and user entries prompt
    public List<string>_questions = new List<string>(); 
    public List<string>_entry = new List<string>();

    
    //method to create the questions
    public void Prompt()
    {
        //adding a list of questions for the journal
        string question1 = "Describe a spiritual experience you had today: ";
        string question2 = "Did you meet a different or special person today? ";
        string question3 = "Did you meet a different or special place today? ";
        _questions.Add(question1);
        _questions.Add(question2);
        _questions.Add(question3);
    }


    //method to get and add user entries
    public void Entries()
    {
        Console.WriteLine("ss");
        string userQuestion1 = Console.ReadLine();


        string userQuestion2 = Console.ReadLine();


        string userQuestion3 = Console.ReadLine();
    }
} 
