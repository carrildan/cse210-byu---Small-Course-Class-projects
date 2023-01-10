using System;

class Program
{
    static void Main(string[] args)
    {
        //generate a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        //keep track of user attempts
        int userAttempts = 0;

        //first question to explain there is a random number
        Console.WriteLine("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int intMagicNumber = int.Parse(magicNumber);
        
        //user guess
        Console.Write("What is your guess? ");
        string userInput = Console.ReadLine();
        int intUserInput = int.Parse(userInput);
        userAttempts += 1;

        //while playAgain is = yes, it will play again
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            while (intUserInput != magicNumber)
            {
                if (intUserInput < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    userAttempts += 1;
                    userInput = Console.ReadLine();
                    intUserInput = int.Parse(userInput);
                }
                else if (intUserInput > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    userAttempts += 1;
                    userInput = Console.ReadLine();
                    intUserInput = int.Parse(userInput);
                }                    
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Your total attemps is: {userAttempts}");
            //asks the user if wants to play again.
            Console.Write("Play Again? ");
            playAgain = Console.ReadLine();            
        }
        //if user says no, game over
        Console.Write("Game Over");

    }
}