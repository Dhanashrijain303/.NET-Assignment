public class Bike : Vehicle
{
    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}