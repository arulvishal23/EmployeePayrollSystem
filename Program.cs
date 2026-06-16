using System;

class Program
{
    static void Main()
    {
        Employee emp;

        emp = new Developer(101, "Arul", 50000, 10000);

        Console.WriteLine("===== Developer =====");
        emp.DisplayEmployeeDetails();
        Console.WriteLine("Total Salary : " +
                          emp.CalculateSalary());

        Console.WriteLine();

        emp = new Manager(102, "John", 70000, 20000);

        Console.WriteLine("===== Manager =====");
        emp.DisplayEmployeeDetails();
        Console.WriteLine("Total Salary : " +
                          emp.CalculateSalary());

        Console.WriteLine();

        emp = new Tester(103, "David", 40000, 5000);

        Console.WriteLine("===== Tester =====");
        emp.DisplayEmployeeDetails();
        Console.WriteLine("Total Salary : " +
                          emp.CalculateSalary());

        Console.ReadLine();
    }
}
