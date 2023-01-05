using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your grade percentage: ");
        string userGrade = Console.ReadLine();
        int userGradeInt = int.Parse(userGrade);

        string letter;
        string userMessage;

        if (userGradeInt >= 90)
        {
            letter = "A";
        }
        else if (userGradeInt >= 80)
        {
            letter = "B";
        }
        else if (userGradeInt >= 70)
        {
            letter = "C";
        }
        else if (userGradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (userGradeInt >= 70)
        {
            userMessage = "Congratulations, you passed!";
        }
        else
        {
            userMessage = "You did not pass this time. Try again and you will succeed!";
        }

        Console.Write(userMessage);

    }
}