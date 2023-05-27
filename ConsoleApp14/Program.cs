using System;

class Employee
{
    public string Name { get; set; }
    public decimal NetSalary { get; set; }
    public decimal Taxes { get; set; }
    public decimal Insurance { get; set; }

    public decimal CalculateSalary()
    {
        return (NetSalary - Insurance) / Taxes;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        Console.WriteLine("please enter your name:");
        emp.Name = Console.ReadLine();

        Console.WriteLine("enter your netsalary:");
        emp.NetSalary = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("enter your tax:");
        emp.Insurance = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("enter your insurance:");
        emp.Taxes = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("{0} your earnings: {1:C}", emp.Name, emp.CalculateSalary());
    }
}