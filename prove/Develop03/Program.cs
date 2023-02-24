using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a reference for the scripture
        Reference reference = new Reference();
        reference.SetReference("Proverbs", "1", "5","");


        //creates a new scripture
        Scripture newScripture = new Scripture("A wise man will hear, and will increase learning; and a man of understanding shall attain unto wise counsels:");
        

        //render a scripture to start
        Console.WriteLine($"{reference.GetReference()} {newScripture.getScripture()}");
        Console.WriteLine("");


        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string user = Console.ReadLine();

        
        //generates random words, hide a word and display scripture updated
        Word newWord = new Word(newScripture.SplitWords());


        //displays content while user do not type quit
        while (user != "quit")
       { 
        //clear the console to update the content
        Console.Clear();
        newWord.RandomWord();
        newWord.HideWords();

        //displays the reference
        Console.Write(reference.GetReference());
        //displays scripture with hidden words
        newWord.Display();


        if (newWord.EndGame() == true)
            break;
        


        Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
        user = Console.ReadLine();
       }
    }
}