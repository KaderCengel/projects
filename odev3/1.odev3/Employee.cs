

namespace _1.odev3;

class Employee
{
    public Employee(double salary)
    {
        Salary = salary;
    }
    public int Id { set; get; }
    public string Name { set; get; }
    public double Salary { set; get; }
    public string Department { set; get; }
    public virtual double CalculateBonus()
    {
        return 0;
    }
}
