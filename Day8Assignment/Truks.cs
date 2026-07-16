public class Truck : Vehicle
{
    public override double CalculateDiscount()
    {
        return Price * 0.12;
    }
}