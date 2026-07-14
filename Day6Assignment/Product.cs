using System;

// PROBLEM STATEMENT 2

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public void Display()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Product ID   : " + ProductId);
        Console.WriteLine("Product Name : " + ProductName);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Stock        : " + Stock);
    }
}