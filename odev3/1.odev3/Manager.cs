

namespace _1.odev3;

class Manager:Employee
{
    public int TeamSize { set; get; }
    public Manager(double salary) : base(salary) { }
    public override double CalculateBonus()
    {

        return Salary * 0.20;

    }
}
