using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a new scripture
        Scripture newScripture = new Scripture("7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        

        //render a scripture
        Console.WriteLine(newScripture.getScripture());
        Console.WriteLine("");

        Word newWord = new Word(newScripture.HideWords());

        string user = "";
        while (user != "quit")
       { 
        
        //prompts the question
        Console.WriteLine("\nPlease enter to continue or type ´quit` to finish:");
        user = Console.ReadLine();

        Console.Clear();
        newWord.IsHidden();
        newWord.Display();
        
       }
        
        //Console.WriteLine("BBB");
    }
}