using System;

class Program
{
    static void Main(string[] args)
    {
        //generate a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        //keep track of user attempts
        int userAttempts = 0;


        //first question to explain there is a random number
        Console.WriteLine("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int intMagicNumber = int.Parse(magicNumber);
    

        //while playAgain is = yes, it will play again
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            //user guess
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int intUserInput = int.Parse(userInput);
            userAttempts += 1;


            if (intUserInput < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (intUserInput > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (intUserInput == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Your total attempts is: {userAttempts}");
                //erase the attempts when the user guesses correctly
                userAttempts = 0;


                //prompt the user to play again.
                Console.Write("Play again? ");
                playAgain = Console.ReadLine();         


                //generates a new random number if user wants to play again
                if (playAgain == "yes")
                {
                    magicNumber = randomGenerator.Next(1, 5);
                    Console.WriteLine("What is the magic number? ");
                }      
            }
        }
        Console.Write("Game Over!");
     
  
    }
}