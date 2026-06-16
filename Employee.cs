using System;

abstract class Employee
{
    public int EmployeeId;
    public string EmployeeName;
    public double BasicSalary;

    public Employee(int id, string name, double salary)
    {
        EmployeeId = id;
        EmployeeName = name;
        BasicSalary = salary;
    }

    public abstract double CalculateSalary();

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID   : " + EmployeeId);
        Console.WriteLine("Employee Name : " + EmployeeName);
        Console.WriteLine("Basic Salary  : " + BasicSalary);
    }
}
