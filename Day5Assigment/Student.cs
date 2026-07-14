public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string Department { get; set; }
    public List<Course> Courses = new List<Course>();

    public virtual double CalculateFee()
    {
        return 0;
    }
}