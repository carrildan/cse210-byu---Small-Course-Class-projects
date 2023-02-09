using System;

class Program
{
    static void Main(string[] args)
    {
        //calls scripture class and displays the scripture
        Word scripture = new Word();
        scripture.ToHidden();
        //scripture.Display();

        //prompts the question
        Console.WriteLine("\nPlease enter to continue or type ´quit` to finish:");
        string user = Console.ReadLine();

        //Console.Clear();
        //Console.WriteLine("BBB");
    }
}