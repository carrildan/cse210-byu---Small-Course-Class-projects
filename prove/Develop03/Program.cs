using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a new scripture
        Scripture newScripture = new Scripture("A wise man will hear, and will increase learning; and a man of understanding shall attain unto wise counsels:");
        newScripture.addingWords();

        //render a scripture
        Console.WriteLine(newScripture.getScripture());
        Console.WriteLine("");


        Console.WriteLine("Choose your option");
        string user = Console.ReadLine();

        while (user != "quit")
       { 
        newScripture.HideWords();
        newScripture.Display();
        Console.WriteLine("Choose your option");
        user = Console.ReadLine();
        //prompts the question
        
        
       }
        
        //Console.WriteLine("BBB");
    }
}