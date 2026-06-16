using System;
class Tester : Employee
{
    double Incentive;

    public Tester(int id, string name,
                  double salary, double incentive)
        : base(id, name, salary)
    {
        Incentive = incentive;
    }

    public override double CalculateSalary()
    {
        return BasicSalary + Incentive;
    }
}