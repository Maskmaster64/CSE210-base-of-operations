using System;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    public double TotalCost()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.TotalCost();
        }

        if (_customer.IsAmerican())
        {
            subtotal += 5;
        }
        else
        {
            subtotal += 35;
        }

        return subtotal;
    }

    public void DisplayLable()
    {
        _customer.DisplayCustomer();
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
        Console.WriteLine($"Total Cost: ${TotalCost()}");
    }
}
