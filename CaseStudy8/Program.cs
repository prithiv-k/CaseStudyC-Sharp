using System;

public class Employee
{
    public int EmpCode { get; set; }
    public string EmpName { get; set; }
    public string Email { get; set; }
    public string DeptName { get; set; }
    public string Location { get; set; }
}

public interface IEmployee<T> where T : Employee
{
    string PrintEmployeeDetails(T employee);
}

public interface IFullTimeEmployee : IEmployee<Employee>
{
    double Basic { get; set; }
    double Hra { get; set; }
    double Da { get; set; }
    double NetSalary { get; set; }
    double CalculateSalary();
}

public interface IPartTimeEmployee : IEmployee<Employee>
{
    double Basic { get; set; }
    double Da { get; set; }
    double NetSalary { get; set; }
    double CalculateSalary();
}

public class FullTimeEmployee : Employee, IFullTimeEmployee
{
    public double Basic { get; set; }
    public double Hra { get; set; }
    public double Da { get; set; }
    public double NetSalary { get; set; }

    public double CalculateSalary()
    {
        Hra = Basic * 0.15;
        Da = Basic * 0.10;
        NetSalary = Basic + Hra + Da;
        return NetSalary;
    }

    public string PrintEmployeeDetails(Employee employee)
    {
        return $"{employee.EmpCode}\t{employee.EmpName}\t{employee.Email}\t{employee.DeptName}\t{employee.Location}";
    }
}

public class PartTimeEmployee : Employee, IPartTimeEmployee
{
    public double Basic { get; set; }
    public double Da { get; set; }
    public double NetSalary { get; set; }

    public double CalculateSalary()
    {
        Da = Basic * 0.05;
        NetSalary = Basic + Da;
        return NetSalary;
    }

    public string PrintEmployeeDetails(Employee employee)
    {
        return $"{employee.EmpCode}\t{employee.EmpName}\t{employee.Email}\t{employee.DeptName}\t{employee.Location}";
    }
}

class Program
{
    static void Main()
    {
        // Part-Time Employee
        PartTimeEmployee pte = new PartTimeEmployee
        {
            EmpCode = 100,
            EmpName = "Scott",
            Email = "scott@gmail.com",
            DeptName = "ODC",
            Location = "Pune",
            Basic = 10000
        };
        pte.CalculateSalary();
        Console.WriteLine(pte.PrintEmployeeDetails(pte));
        Console.WriteLine($"Net Salary For Part Time Employee is: {pte.NetSalary}\n");

        // Full-Time Employee
        FullTimeEmployee fte = new FullTimeEmployee
        {
            EmpCode = 101,
            EmpName = "Tiger",
            Email = "tiger@gmail.com",
            DeptName = "Hr",
            Location = "Pune",
            Basic = 20000
        };
        fte.CalculateSalary();
        Console.WriteLine(fte.PrintEmployeeDetails(fte));
        Console.WriteLine($"Net Salary For Full Time Employee is: {fte.NetSalary}");
    }
}
