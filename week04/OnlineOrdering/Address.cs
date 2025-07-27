using System.Data;
using System.Globalization;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _stateProvince;
    }
    public void SetState(string state)
    {
        _stateProvince = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public bool IsInUSA()
    {
        string lowerCaseCountry = _country.Trim().ToLower();
        if (lowerCaseCountry == "usa" || lowerCaseCountry == "united states" || lowerCaseCountry == "us" || lowerCaseCountry == "u.s.a" || lowerCaseCountry == "u.s.")
        {
            return true;
        }
        return false;
    }
    public string GetCustomerAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}