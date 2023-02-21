using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a reference for the scripture
        Reference reference = new Reference("Proverbs", "1", "5", "6");
        //creates a new scripture
        Scripture newScripture = new Scripture("A wise man will hear, and will increase learning; and a man of understanding shall attain unto wise counsels:");
        newScripture.SplitWords();

        //render a scripture
        Console.WriteLine(newScripture.getScripture());
        Console.WriteLine("");



        Console.WriteLine("Choose your option");
        string user = Console.ReadLine();

        while (user != "quit")
       { 
        var a = newScripture.HideWords();
        Word newWord = new Word(a);
        newWord.IsHidden();
        newWord.Display();

        Console.WriteLine("Choose your option");
        user = Console.ReadLine();
        Console.Clear();
        
        
       }
        
        //Console.WriteLine("BBB");
    }
}