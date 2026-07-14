// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Customer customer = new Customer();
        List<Product> products = new List<Product>();
        Cart cart = new Cart();

        Console.WriteLine("===== CUSTOMER REGISTRATION =====");

        Console.Write("Enter Customer ID: ");
        customer.CustomerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        customer.Name = Console.ReadLine();

        Console.Write("Enter Email: ");
        customer.Email = Console.ReadLine();

        Console.Write("Enter Password: ");
        customer.Password = Console.ReadLine();

        Console.WriteLine("\nRegistration Successful");

        // Login
        int attempts = 0;
        bool login = false;

        while (attempts < 3)
        {
            Console.Write("\nEnter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (email == customer.Email && password == customer.Password)
            {
                Console.WriteLine("\nWelcome " + customer.Name);
                login = true;
                break;
            }
            else
            {
                Console.WriteLine("Invalid Email or Password");
                attempts++;
            }
        }

        if (!login)
        {
            Console.WriteLine("Account Locked");
            return;
        }

        // Add Products
        Console.Write("\nHow many products do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Product p = new Product();

            Console.Write("\nProduct ID: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            products.Add(p);
        }

        Console.WriteLine("\n===== PRODUCT LIST =====");

        foreach (Product p in products)
        {
            p.Display();
        }

        // Search Product
        Console.Write("\nEnter Product Name to Search: ");
        string search = Console.ReadLine();

        Product found = null;

        foreach (Product p in products)
        {
            if (p.ProductName.ToLower() == search.ToLower())
            {
                found = p;
                break;
            }
        }

        if (found != null)
        {
            Console.WriteLine("\nProduct Found");
            found.Display();
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

        // Add To Cart
        while (true)
        {
            Console.Write("\nEnter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Product product = null;

            foreach (Product p in products)
            {
                if (p.ProductId == id)
                {
                    product = p;
                    break;
                }
            }

            if (product == null)
            {
                Console.WriteLine("Product Not Found");
            }
            else
            {
                Console.Write("Enter Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                if (qty <= product.Stock)
                {
                    cart.AddItem(product, qty);
                    product.Stock -= qty;
                    Console.WriteLine("Added To Cart");
                }
                else
                {
                    Console.WriteLine("Stock Not Available");
                }
            }

            Console.Write("\nAdd Another Product? (1.Yes 2.No): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 2)
                break;
        }

        // Display Cart
        cart.DisplayCart();

        double total = cart.CalculateTotal();
        double discount = cart.CalculateDiscount(total);
        double finalAmount = total - discount;

        Console.WriteLine("\nTotal Amount : " + total);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("Final Amount : " + finalAmount);

        // Payment
        Console.WriteLine("\nChoose Payment Method");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash On Delivery");

        int payment = Convert.ToInt32(Console.ReadLine());

        switch (payment)
        {
            case 1:
                Console.WriteLine("Payment Successful using UPI");
                break;

            case 2:
                Console.WriteLine("Payment Successful using Credit Card");
                break;

            case 3:
                Console.WriteLine("Payment Successful using Debit Card");
                break;

            case 4:
                Console.WriteLine("Payment Successful using Cash On Delivery");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}
