using System;
class Developer : Employee
{
    double Allowance;

    public Developer(int id, string name,
                     double salary, double allowance)
        : base(id, name, salary)
    {
        Allowance = allowance;
    }

    public override double CalculateSalary()
    {
        return BasicSalary + Allowance;
    }
}