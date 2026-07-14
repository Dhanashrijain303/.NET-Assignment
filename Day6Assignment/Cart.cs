using System;
using System.Collections.Generic;


// PROBLEM STATEMENT 4
public class Cart
{
    public List<CartItem> Items = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        CartItem item = new CartItem();
        item.Product = product;
        item.Quantity = quantity;

        Items.Add(item);
    }


// PROBLEM STATEMENT 5
    public double CalculateTotal()
    {
        double total = 0;

        foreach (CartItem item in Items)
        {
            total += item.TotalPrice();
        }

        return total;
    }

    public void DisplayCart()
    {
        Console.WriteLine("\n------ CART ------");

        foreach (CartItem item in Items)
        {
            Console.WriteLine(item.Product.ProductName + " x " + item.Quantity + " = " + item.TotalPrice());
        }
    }

    public double CalculateDiscount(double total)
    {
        if (total >= 10000)
            return total * 0.30;
        else if (total >= 5000)
            return total * 0.20;
        else if (total >= 1000)
            return total * 0.10;
        else
            return 0;
    }
}