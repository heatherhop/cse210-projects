public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }
    public void SetCustomerName(String name)
    {
        _name = name;
    }
    public Address GetCustomerAddress()
    {
        return _address;
    }
    public void SetCustomerAddess(Address address)
    {
        _address = address;
    }
    public bool IsCustomerInUSA()
    {
        return _address.IsInUSA();
    }
}