using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine(" --- Order 1 Packing Label Details --- ");
        Console.WriteLine("");
        Product product1 = new Product("Laptop", "COMP001", 1250.00, 1);
        Product product2 = new Product("Mouse", "MOUS001", 45.00, 2);
        Product product3 = new Product("Keyboard", "KEYB001", 89.00, 2);
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);
        Console.WriteLine("");
        Address address1 = new Address("360 Scenic View Drive", "Hyrum", "UT", "USA");
        Customer customer1 = new Customer("Heather Hopkins", address1);

        Order order1 = new Order(customer1, products1);
        order1.CreatePackingLabel();
        order1.GetTotalOrderCost();
        order1.CreateShippingLabel();


        Console.WriteLine(" --- Order 2 Packing Label Details --- ");
        Console.WriteLine("");
        Product product4 = new Product("Charger Cord", "CORD001", 12.00, 2);
        Product product5 = new Product("Ear Buds", "EARB001", 35.00, 1);
        Product product6 = new Product("Wireless Speaker", "WSPK001", 89.00, 1);
        List<Product> products2 = new List<Product>();
        products2.Add(product4);
        products2.Add(product5);
        products2.Add(product6);
        Console.WriteLine("");
        Address address2 = new Address("815 Dillon Drive", "North Ridge", "Derbyshire", "Denmark");
        Customer customer2 = new Customer("Bryce Lane", address2);

        Order order2 = new Order(customer2, products2);
        order2.CreatePackingLabel();
        order2.GetTotalOrderCost();
        order2.CreateShippingLabel();


    }
}