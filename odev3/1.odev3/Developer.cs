

namespace _1.odev3;

class Developer:Employee
{
    public string About { set; get; }
    public Developer(double salary) : base(salary) { }
    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }
}
