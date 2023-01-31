using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1, 1);
        Fraction fraction2 = new Fraction(6, 1);
        Fraction fraction3 = new Fraction(6, 7);

        fraction1.SetTop(1);

        fraction1.SetBottom(3);
        
        Console.WriteLine(fraction1.GetFractionString());
        Console.Write(fraction1.GetDecimalValue());
        
    }
}