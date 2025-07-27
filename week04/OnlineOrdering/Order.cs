using System.Security.Cryptography.X509Certificates;

public class Order
{
    
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public List<Product> GetProduct()
    {
        return _products;
    }
    public void SetProduct(List<Product> products)
    {
        _products = products;
    }
    public void GetTotalOrderCost()
    {
        double totalProductsCost = 0.0;

        foreach (Product product in _products)
        {
            double productTotal = product.GetTotalProductCost();
            totalProductsCost += productTotal;
        }
        double shippingCost;
        if (_customer.IsCustomerInUSA())
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }
        double orderTotal = totalProductsCost + shippingCost;
        Console.WriteLine($"Order Subtotal: ${totalProductsCost}.00");
        Console.WriteLine($"Shipping: ${shippingCost}.00");
        Console.WriteLine($"Order Total: ${orderTotal}.00");
    }

    public void CreatePackingLabel()
    {
        Console.WriteLine($"Products Ordered:");
        Console.WriteLine("");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: {product.GetName()}");
            Console.WriteLine($"Product ID: {product.GetProductID()}");
            Console.WriteLine($"Price per Unit: ${product.GetProductPrice()}.00");
            Console.WriteLine($"Quantity: {product.GetProductQuantity()}");
            Console.WriteLine("");
        }
    }

    public void CreateShippingLabel()
    {
        Console.WriteLine("");
        Console.WriteLine($"Name: {_customer.GetCustomerName()}");
        Console.WriteLine($"Address: {_customer.GetCustomerAddress().GetCustomerAddress()}");

    }
}