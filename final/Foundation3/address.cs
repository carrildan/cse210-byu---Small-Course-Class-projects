using System;

public class Addresses
{
    //holds a street
    private string _street;

    //holds a city
    private string _city;

    //holds a state
    private string _state;

    //holds a province
    private string _province;


    public Addresses(string street, string city, string state, string province)
    {
        _street = street;
        _city = city;
        _state = state;
        _province = province;
    }


    public string GetAddresses()
    {
        return ($"Street: {_street}\n{_city} - {_state} ({_province})\n");
    }
}