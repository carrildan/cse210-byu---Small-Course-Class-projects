using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("television",150, 100, 5);     

            
        Customer customer = new Customer("Daniel");
        customer.SetAddress("daniel street","valencia","Valencia","valenciana","spain");
        Console.Write(customer.GetAdress());
        Console.WriteLine($"\n{customer.CustomerInUsa()}");
        


        
    }
}