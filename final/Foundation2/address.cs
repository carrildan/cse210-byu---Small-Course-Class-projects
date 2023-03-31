using System;

public class Address
{
    //holds a street
    private string _street;

    //holds a city
    private string _city;

    //holds a state
    private string _state;

    //holds a province
    private string _province;

    //hods a country
    private string _country;


    public Address(string street, string city, string state, string province, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }


    //returns a string in the address format
    public string GetAddress()
    {
        return ($"Street: {_street}\nCity: {_city}\nState: {_state}\nProvince. {_province}\nCountry: {_country}");
    }
    

    //returns weather address is in USA
    public bool AddressInUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
    