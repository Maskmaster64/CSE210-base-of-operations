using System;
public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double total = _price * _quantity;
        return total;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"id: {_id} name: {_name}");
        Console.WriteLine($"price: {_price} quantity:{_quantity}");
    }
}