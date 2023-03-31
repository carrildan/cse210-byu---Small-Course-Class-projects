using System;

public class Customer
{
    //holds a user´s name
    private string _customerName;

    //customer´s address
    private Address _customerAddress;


    public Customer(string name)
    {
        _customerName = name;
    }


    //sets the properties for  _costomerAddress
    public void SetAddress(string street, string city, string state, string province, string country)
    {
        _customerAddress = new Address(street,city,state,province,country);
    }


    //returns a string with customer´s address information
    public string GetAdress()
    {
        return _customerAddress.GetAddress();
    }


    //returns weather address is located in usa
    public bool CustomerInUsa()
    {
        if (_customerAddress.AddressInUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}