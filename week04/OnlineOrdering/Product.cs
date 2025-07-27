public class Product
{
    private string _productName;
    private string _productID;
    private double _pricePerUnit;
    private int _productQuantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _productName = name;
        _productID = productID;
        _pricePerUnit = price;
        _productQuantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }
    public void SetName(string name)
    {
        _productName = name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }
    public double GetProductPrice()
    {
        return _pricePerUnit;
    }
    public void SetProductPrice(double price)
    {
        _pricePerUnit = price;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public void SetProductQuantity(int quantity)
    {
        _productQuantity = quantity;
    }

    public double GetTotalProductCost()
    {
        return (double)_pricePerUnit * (int)_productQuantity;
    }
}