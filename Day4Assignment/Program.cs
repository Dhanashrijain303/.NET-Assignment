// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// Abstract Class
abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int LeaveBalance { get; set; }

    public abstract void SetLeaveBalance();

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID : " + EmployeeId);
        Console.WriteLine("Name        : " + Name);
        Console.WriteLine("Department  : " + Department);
        Console.WriteLine("Leave Balance : " + LeaveBalance);
        Console.WriteLine("----------------------------");
    }
}

// Permanent Employee
class PermanentEmployee : Employee
{
    public override void SetLeaveBalance()
    {
        LeaveBalance = 24;
    }
}

// Contract Employee
class ContractEmployee : Employee
{
    public override void SetLeaveBalance()
    {
        LeaveBalance = 12;
    }
}

// Leave Request Class
class LeaveRequest
{
    public int LeaveId { get; set; }
    public int EmployeeId { get; set; }
    public int NumberOfDays { get; set; }
    public string Reason { get; set; }

    public void DisplayLeave()
    {
        Console.WriteLine("Leave ID      : " + LeaveId);
        Console.WriteLine("Employee ID   : " + EmployeeId);
        Console.WriteLine("Days          : " + NumberOfDays);
        Console.WriteLine("Reason        : " + Reason);
        Console.WriteLine("----------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Task 1
        List<Employee> employees = new List<Employee>();

        PermanentEmployee e1 = new PermanentEmployee()
        {
            EmployeeId = 101,
            Name = "gita",
            Department = "HR"
        };
        e1.SetLeaveBalance();

        PermanentEmployee e2 = new PermanentEmployee()
        {
            EmployeeId = 102,
            Name = "vidhi",
            Department = "Finance"
        };
        e2.SetLeaveBalance();

        ContractEmployee e3 = new ContractEmployee()
        {
            EmployeeId = 103,
            Name = "krushna",
            Department = "IT"
        };
        e3.SetLeaveBalance();

        ContractEmployee e4 = new ContractEmployee()
        {
            EmployeeId = 104,
            Name = "arpita",
            Department = "marketing"
        };
        e4.SetLeaveBalance();

        employees.Add(e1);
        employees.Add(e2);
        employees.Add(e3);
        employees.Add(e4);

        // Task 2
        Console.WriteLine("Employee Details");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        // Task 3
        List<LeaveRequest> leaveRequests = new List<LeaveRequest>()
        {
            new LeaveRequest(){ LeaveId=1, EmployeeId=101, NumberOfDays=3, Reason="Medical"},
            new LeaveRequest(){ LeaveId=2, EmployeeId=103, NumberOfDays=2, Reason="Personal"},
            new LeaveRequest(){ LeaveId=3, EmployeeId=102, NumberOfDays=5, Reason="Vacation"}
        };

        // Task 4
        Console.WriteLine("\nLeave Requests");
        foreach (LeaveRequest leave in leaveRequests)
        {
            leave.DisplayLeave();
        }

        // Task 5
        Console.WriteLine("\nPermanent Employees");
        foreach (Employee emp in employees)
        {
            if (emp is PermanentEmployee)
            {
                emp.DisplayDetails();
            }
        }

        // Task 6
        Console.WriteLine("\nEmployee with ID 103");
        Employee employee = employees.Find(e => e.EmployeeId == 103);

        if (employee != null)
        {
            employee.DisplayDetails();
        }

        // Task 7
        Console.WriteLine("Total Employees : " + employees.Count);

        // Task 8
        Console.WriteLine("Total Leave Requests : " + leaveRequests.Count);
    }
}

