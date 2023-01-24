using System.Collections.Generic;
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
        string question1 = (_questions[0]);
        Console.WriteLine(question1);
        string userEntry1 = Console.ReadLine();


        string question2 = (_questions[1]);
        Console.WriteLine(question2);
        string userEntry2 = Console.ReadLine();


        string question3 = (_questions[2]);
        Console.WriteLine(question3);
        string userEntry3 = Console.ReadLine();


        //stores user´s entries into the _entry list
        _entry.Add(userEntry1);
        _entry.Add(userEntry2);
        _entry.Add(userEntry3);
    }


    //method for menu option 3(display) display the questions to the user
    public void Display()
    {
        Console.WriteLine($"24/01/23 - {_questions[0]} \n{_entry[0]}");
        Console.WriteLine($"24/01/23 - {_questions[1]} \n{_entry[1]}");
        Console.WriteLine($"24/01/23 - {_questions[2]} \n{_entry[2]}");
       
    }
} 
