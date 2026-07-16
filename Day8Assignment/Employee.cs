public class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeId { get; set; }

    public void Login()
    {
        Console.Write("Enter Employee Name : ");
        EmployeeName = Console.ReadLine();

        Console.Write("Enter Employee ID : ");
        EmployeeId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nWelcome {EmployeeName}");
    }
}