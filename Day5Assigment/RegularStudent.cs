class RegularStudent : Student
{
    public override double CalculateFee()
    {
        int credits = 0;
        foreach (Course c in Courses)
            credits += c.Credits;

        return credits * 1000;
    }
}

