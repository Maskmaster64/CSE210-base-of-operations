using System;

class Program
{
    static void Main(string[] args)
    {
        Address home = new Address("57 tanner rd", "Cascade", "Montana", "USA");
        Customer ashton = new Customer("Ashton", home);

        Product apple = new Product("Apple", 001, 1.50, 4);
        Product turky_leg = new Product("Turky leg", 002, 4.25, 3);
        Product milk_gallon = new Product("Gallon milk", 003, 6.75, 2);

        Order my_order = new Order(ashton);
        my_order.AddProduct(apple);
        my_order.AddProduct(turky_leg);
        my_order.AddProduct(milk_gallon);

        my_order.DisplayLable();
    }
}