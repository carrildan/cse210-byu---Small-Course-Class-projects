using System;

public class Order
{
    //holds a list of products
    private List<Product> _listOfProducts = new List<Product>();

    //holds a list of costumers
    private Customer _customer;

    //cost for shipping in USA
    private double _usaShippingCost;

    //cost for shipping out of USA
    private double _foreignShippingCost;


    public Order()
    {
        _usaShippingCost = 5.00;
        _foreignShippingCost = 35.00;
    }


    //sets a new customer
    public void SetCustomer(Customer person)
    {
        _customer = person;
    }


    //add a new product to the list
    public void SetProduct(Product product)
    {
        _listOfProducts.Add(product);
    }


    //calculate the total cost of the order
    public double TotalCost()
    {
        double totalPrice = 0.0;
        foreach(Product item in _listOfProducts)
        {
            if(_customer.CustomerInUsa() == true)
            {
                totalPrice = item.GetProductPrice() + _usaShippingCost;
            }
            else
            {
                totalPrice = item.GetProductPrice() + _foreignShippingCost;
            }
            
        }
        return totalPrice;
    }


    //return a packing label
    public void PackingLabel()
    {
        foreach(Product item in _listOfProducts)
        {
            Console.WriteLine($"Packing label: Product: {item.GetProductName()} - {item.GetProductId()} - total price: {TotalCost()}");
        }
    }      
}