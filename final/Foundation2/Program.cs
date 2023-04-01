using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a new customer
        Customer customer = new Customer("Daniel");
        customer.SetAddress("daniel street","valencia","Valencia","valenciana","USA");
        

        //creates a new order
        Order order = new Order();
        order.SetProduct(new Product("television",150, 100, 200.50));
        order.SetCustomer(customer);
        order.PackingLabel();  
    }
}