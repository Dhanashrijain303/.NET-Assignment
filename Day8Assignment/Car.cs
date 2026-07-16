public class Car : Vehicle
{
    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }
}