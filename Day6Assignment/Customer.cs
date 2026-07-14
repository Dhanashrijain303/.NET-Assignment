using System;

// PROBLEM STATEMENT 1

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public void Display()
    {
        Console.WriteLine("Customer ID : " + CustomerId);
        Console.WriteLine("Name        : " + Name);
        Console.WriteLine("Email       : " + Email);
    }
}