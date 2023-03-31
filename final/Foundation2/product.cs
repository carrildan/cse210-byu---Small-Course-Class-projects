using System;

public class Product
{
    //for the name of a product
    private string _productName;

    //for the id of a product
    private int _productId;

    //sets the price of a product
    private double _unitPrice;

    //sets the quantity of a product
    private int _productQuantity;


    public Product(string productName, int productId, int productQuantity, double unitPrice)
    {
        _productName = productName;
        _productId = productId;
        _productQuantity = productQuantity;
        _unitPrice = unitPrice;
    }


    //returns the product price
    public double GetProductPrice()
    {
        return _unitPrice * _productQuantity;
    }
}
