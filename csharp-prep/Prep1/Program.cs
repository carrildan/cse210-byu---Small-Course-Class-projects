using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string userFirstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string userLastName = Console.ReadLine();       

        Console.WriteLine($"Your name is {userLastName}, {userFirstName} {userLastName}."); 
    }
}