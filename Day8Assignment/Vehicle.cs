using System;

public class Vehicle
{
    public int VehicleId { get; set; }
    public string VehicleName { get; set; }
    public string VehicleType { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public int ManufacturingYear { get; set; }

    public virtual double CalculateDiscount()
    {
        return 0;
    }

    public virtual void Display()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Vehicle ID   : " + VehicleId);
        Console.WriteLine("Vehicle Name : " + VehicleName);
        Console.WriteLine("Type         : " + VehicleType);
        Console.WriteLine("Brand        : " + Brand);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Year         : " + ManufacturingYear);
    }
}