using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>();

        int user = -1;
        while (user != 0)
        {
            Console.Write("Enter number: ");
            user = int.Parse(Console.ReadLine());
            numberList.Add(user);
        }

        int sum = 0;
        double average = 0.0D;
        foreach(int n in numberList)
        {
            sum = sum + n;
            average = sum / (numberList.Count - 1D);
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numberList.Max()}");

    }
}