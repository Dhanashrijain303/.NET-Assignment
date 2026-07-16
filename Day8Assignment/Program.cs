using System;
using System.Collections.Generic;

class Program
{
    static List<Vehicle> vehicles = new List<Vehicle>();

    static void Main()
    {
        Employee emp = new Employee();
        emp.Login();

        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("ABC MOTORS");
            Console.WriteLine("Vehicle Management System");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View All Vehicles");
            Console.WriteLine("3. Search Vehicle");
            Console.WriteLine("4. Update Vehicle Price");
            Console.WriteLine("5. Delete Vehicle");
            Console.WriteLine("6. Calculate Discount");
            Console.WriteLine("7. Show Vehicle Details");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddVehicle();
                    break;

                case 2:
                    DisplayVehicles();
                    break;

                case 3:
                    Console.WriteLine("Will be added in Part 3");
                    break;

                case 4:
                    Console.WriteLine("Will be added in Part 3");
                    break;

                case 5:
                    Console.WriteLine("Will be added in Part 3");
                    break;

                case 6:
                    Console.WriteLine("Will be added in Part 3");
                    break;

                case 7:
                    Console.WriteLine("Will be added in Part 3");
                    break;

                case 8:
                    Console.WriteLine("Thank you for using ABC Motors System.");
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void AddVehicle()
    {
        Console.WriteLine("Select Vehicle Type");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Bike");
        Console.WriteLine("3. Truck");

        int type = Convert.ToInt32(Console.ReadLine());

        Vehicle v;

        if (type == 1)
            v = new Car();
        else if (type == 2)
            v = new Bike();
        else
            v = new Truck();

        Console.Write("Vehicle ID : ");
        v.VehicleId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Vehicle Name : ");
        v.VehicleName = Console.ReadLine();

        Console.Write("Brand : ");
        v.Brand = Console.ReadLine();

        Console.Write("Price : ");
        v.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Manufacturing Year : ");
        v.ManufacturingYear = Convert.ToInt32(Console.ReadLine());

        if (v is Car)
            v.VehicleType = "Car";
        else if (v is Bike)
            v.VehicleType = "Bike";
        else
            v.VehicleType = "Truck";

        vehicles.Add(v);

        Console.WriteLine("Vehicle Added Successfully.");
    }

    static void DisplayVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No Vehicles Available.");
            return;
        }

        Console.WriteLine("\n----------------------------------------------------------");
        Console.WriteLine("ID\tName\tBrand\tType\tPrice");
        Console.WriteLine("----------------------------------------------------------");

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine($"{v.VehicleId}\t{v.VehicleName}\t{v.Brand}\t{v.VehicleType}\t{v.Price}");
        }
    }

    static void SearchVehicle()
{
    Console.Write("Enter Vehicle ID : ");
    int id = Convert.ToInt32(Console.ReadLine());

    Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);

    if (vehicle != null)
    {
        vehicle.Display();
    }
    else
    {
        Console.WriteLine("Vehicle not found.");
    }
}
     static void UpdateVehiclePrice()
{
    Console.Write("Enter Vehicle ID : ");
    int id = Convert.ToInt32(Console.ReadLine());

    Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);

    if (vehicle != null)
    {
        Console.Write("Enter New Price : ");
        vehicle.Price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Price Updated Successfully.");
    }
    else
    {
        Console.WriteLine("Vehicle ID does not exist.");
    }
}
   static void DeleteVehicle()
{
    Console.Write("Enter Vehicle ID : ");
    int id = Convert.ToInt32(Console.ReadLine());

    Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);

    if (vehicle != null)
    {
        vehicles.Remove(vehicle);
        Console.WriteLine("Vehicle Deleted Successfully.");
    }
    else
    {
        Console.WriteLine("Vehicle not available.");
    }
}
   static void CalculateDiscount()
{
    Console.Write("Enter Vehicle ID : ");
    int id = Convert.ToInt32(Console.ReadLine());

    Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);

    if (vehicle != null)
    {
        double discount = vehicle.CalculateDiscount();
        double finalPrice = vehicle.Price - discount;

        Console.WriteLine("Vehicle Price : " + vehicle.Price);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("Final Price : " + finalPrice);
    }
    else
    {
        Console.WriteLine("Vehicle not found.");
    }
}
   static void ShowVehicleDetails()
{
    Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
    string type = Console.ReadLine().ToLower();

    switch (type)
    {
        case "car":
            Console.WriteLine("Car is a four wheeler.");
            Console.WriteLine("Suitable for family.");
            break;

        case "bike":
            Console.WriteLine("Bike is fuel efficient.");
            Console.WriteLine("Suitable for city rides.");
            break;

        case "truck":
            Console.WriteLine("Truck is used for transportation.");
            Console.WriteLine("Heavy load vehicle.");
            break;

        default:
            Console.WriteLine("Invalid Vehicle Type.");
            break;
    }
}
}