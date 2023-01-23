using System;

class Program
{
    static void Main(string[] args)
    {
        //render a welcome message
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        
        //menu options
        string menu = ("1. Write \n2. Display \n3. Load \n4. Save\n5. Quit");
        Console.WriteLine(menu);

        //user entry the option
        Console.Write("What would you like to do? ");
        string user = Console.ReadLine();
        int userInt = int.Parse(user);

       
        
    }
}