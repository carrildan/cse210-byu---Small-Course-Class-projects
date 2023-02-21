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
        newScripture.getScripture();
        newScripture.SplitWords();

        //render a scripture
        Console.WriteLine($"{reference.GetReference()} {newScripture.getScripture()}");
        Console.WriteLine("");



        Console.WriteLine("Choose your option");
        string user = Console.ReadLine();

        while (user != "quit")
       { 
        Word newWord = new Word(newScripture.HideWords());
        newWord.Hide();
        Console.Write($"{reference.GetReference()} ");
        newWord.Display();

        Console.WriteLine("Choose your option");
        user = Console.ReadLine();
        Console.Clear();
        
        
       }
        
        //Console.WriteLine("BBB");
    }
}