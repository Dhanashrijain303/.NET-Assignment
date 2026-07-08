// See https://aka.ms/new-console-template for more information

//Q1

/*using System;

class Program
{
    static void Main()
    {
        int[] sales = { 10,20,30,40,50,60 };

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        Console.WriteLine("Monthly Sales of Employees:");

        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": ₹" + sales[i]);

            total += sales[i];

            if (sales[i] > highest)
            {
                highest = sales[i];
            }

            if (sales[i] < lowest)
            {
                lowest = sales[i];
            }
        }

        double average = (double)total / sales.Length;

        Console.WriteLine("Total Sales: ₹" + total);
        Console.WriteLine("Average Sales: ₹" + average);
        Console.WriteLine("Highest Sales: ₹" + highest);
        Console.WriteLine("Lowest Sales: ₹" + lowest);
    }
}
*/

// Q2

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         List<string> books = new List<string>()
        {
            "Maths",
            "Science",
            "Python",
            "Data Structures",
            "Operating System"
        };

        Console.WriteLine("Available Books:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        // Add a new book
        books.Add("Java");

        // Remove an old book
        books.Remove("Maths");

        Console.WriteLine("\nUpdated Book List:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nTotal Number of Books: " + books.Count);
    }
}
