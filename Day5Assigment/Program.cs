// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Student> students = new List<Student>();
    static List<Course> courses = new List<Course>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Register Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Register Course");
            Console.WriteLine("4. View Student Details");
            Console.WriteLine("5. Exit");

            Console.Write("Enter Choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    RegisterStudent();
                    break;

                case 2:
                    AddCourse();
                    break;

                case 3:
                    RegisterCourse();
                    break;

                case 4:
                    ViewStudent();
                    break;

                case 5:
                    return;
            }
        }
    }
    static void RegisterStudent()
{
    Console.Write("ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Department: ");
    string dept = Console.ReadLine();

    Console.WriteLine("1.Regular 2.Scholarship 3.PartTime");
    int type = Convert.ToInt32(Console.ReadLine());

    Student s;

    if (type == 1)
        s = new RegularStudent();
    else if (type == 2)
        s = new ScholarshipStudent();
    else
        s = new PartTimeStudent();

    s.StudentId = id;
    s.StudentName = name;
    s.Department = dept;

    students.Add(s);
}
static void AddCourse()
{
    Course c = new Course();

    Console.Write("Course ID: ");
    c.CourseId = Convert.ToInt32(Console.ReadLine());

    Console.Write("Course Name: ");
    c.CourseName = Console.ReadLine();

    Console.Write("Credits: ");
    c.Credits = Convert.ToInt32(Console.ReadLine());

    courses.Add(c);

}
static void RegisterCourse()
{
    Console.Write("Student ID: ");
    int sid = Convert.ToInt32(Console.ReadLine());

    Student s = students.Find(x => x.StudentId == sid);

    if (s == null)
    {
        Console.WriteLine("Student Not Found");
        return;
    }

    Console.Write("Course ID: ");
    int cid = Convert.ToInt32(Console.ReadLine());

    Course c = courses.Find(x => x.CourseId == cid);

    if (c == null)
    {
        Console.WriteLine("Course Not Found");
        return;
    }

    if (s.Courses.Contains(c))
    {
        Console.WriteLine("Already Registered");
        return;
    }

    if (s.Courses.Count >= 5)
    {
        Console.WriteLine("Maximum 5 Courses Allowed");
        return;
    }

    s.Courses.Add(c);

    Console.WriteLine("Course Registered Successfully");
}
static void ViewStudent()
{
    Console.Write("Student ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Student s = students.Find(x => x.StudentId == id);

    if (s == null)
    {
        Console.WriteLine("Student Not Found");
        return;
    }

    Console.WriteLine("\nStudent Name: " + s.StudentName);
    Console.WriteLine("Department: " + s.Department);

    int credits = 0;

    Console.WriteLine("Courses:");

    foreach (Course c in s.Courses)
    {
        Console.WriteLine(c.CourseName + " (" + c.Credits + ")");
        credits += c.Credits;
    }

    Console.WriteLine("Total Credits: " + credits);
    Console.WriteLine("Total Fee: " + s.CalculateFee());
}
}



