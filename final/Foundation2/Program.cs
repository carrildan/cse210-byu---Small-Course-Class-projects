using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a new customer
        Customer customer = new Customer("Daniel dos Santos Carril");
        customer.SetAddress("daniel street","sagunto","Valencia","valenciana","Spain");
        

        //creates a new order
        Order order = new Order();
        order.SetProduct(new Product("television",150441, 100, 200.50));
        order.SetProduct(new Product("computer", 15045, 10, 150.00));
        order.SetCustomer(customer);
        order.PackingLabel();
        order.ShippingLabel();
        Console.WriteLine(order.TotalCost());  


        //Creates a new order
        Order order2 = new Order();
        order2.SetProduct(new Product("smartphone samsung", 55748, 50, 100.50));
        order2.SetProduct(new Product("freezer", 4446698, 2, 950.00));
        order2.SetCustomer(customer);
        order2.PackingLabel();
        order2.ShippingLabel();
        Console.WriteLine(order2.TotalCost());  
    }
}