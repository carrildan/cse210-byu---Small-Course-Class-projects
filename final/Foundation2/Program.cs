using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("television",150, 100, 5);
        Console.Write(product.GetProductPrice());
    }
}