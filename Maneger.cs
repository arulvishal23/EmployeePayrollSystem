using System;
class Manager : Employee
{
    double Bonus;

    public Manager(int id, string name,
                   double salary, double bonus)
        : base(id, name, salary)
    {
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BasicSalary + Bonus;
    }
}