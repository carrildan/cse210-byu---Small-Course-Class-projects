using System.Collections.Generic;
using System.IO;
public class Journal
{
    //member variables. list for questions creation and user entries prompt
    public List<string>_questions; //new List<string>(); 
    public List<string>_entry = new List<string>();
    public DateTime _date = DateTime.Now;

    
    //method to create the questions
    public void Prompt()
    {   //FEEDBACK - TAKE OFF THE VARIABLES AND PUT THEM DIRECTLY INTO THE LIST
        //adding a list of questions for the journal

        _questions = new List<string>{"Describe a spiritual experience you had today: ", "Share a positive learning or insight you got today: ", 
        "Did you meet a different or special place today?", "Did you meet a good person today?", "Did you help somebody today? Who?"};

        /*
        string question1 = "Describe a spiritual experience you had today: ";
        string question2 = "Did you meet a different or special person today? ";
        string question3 = "Did you meet a different or special place today? ";
        _questions.Add(question1);
        _questions.Add(question2);
        _questions.Add(question3);*/
    }


    // FEEDBACK - IT MUST HAVE A RANDOM FOR QUESTIONS
    //method to get and add user entries along the questions
    public void Entries()
    {
        Random random1 = new Random();
        int randomIndex = random1.Next(0, _questions.Count);
        string randomElement = _questions[randomIndex];
        
       
        //get a random prompt for the user along with his entry
        string question = (randomElement);
        Console.WriteLine(question);
        string userEntry3 = Console.ReadLine();


        //stores questions and user´s entries into the _entry list
        _entry.Add(_date + " - " + question + "\n" + userEntry3 + "\n");
        _questions.Remove(randomElement);
    }


    //method for menu option 3(display) display the questions to the user
    public void Display()
    {
        //iterate the entries and displays the content
        foreach(string line in _entry)
        {
            
            Console.WriteLine(_entry);
        }
        
    }
} 
