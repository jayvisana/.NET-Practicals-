using System;
namespace Practical2 {
    interface EmpSalary
{
    double CalculateSalary();
}
class FtEmp : EmpSalary
{
    public int empId;
    public double basicSalary;
    public double hra;
    public double da;

    public FtEmp()
    {
        Console.WriteLine("Full Time Employee object created");
    }
    public double CalculateSalary()
    {
        return basicSalary + hra + da;
    }

}
class PtEmp : EmpSalary
{
    public int empId;
    public double basicSalary;
    public double hra;
    public double da;

    public PtEmp()
    {
        Console.WriteLine("Part Time Employee object created");
    }
    public double CalculateSalary()
    {
        return basicSalary + hra + da;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Employee Type (F for Full Time, P for Part Time):");
        string empType = Console.ReadLine().ToUpper();
        if (empType == "F")
        {
            FtEmp ftEmp = new FtEmp();
            Console.WriteLine("Enter Full Time Employee Details:");
            Console.Write("Enter Employee ID: ");
            ftEmp.empId = int.Parse(Console.ReadLine());
            Console.Write("Basic Salary: ");
            ftEmp.basicSalary = double.Parse(Console.ReadLine());
            ftEmp.hra = ftEmp.basicSalary * 0.50;
            ftEmp.da = ftEmp.basicSalary * 0.20;

            Console.WriteLine($"Full Time Employee Salary: {ftEmp.CalculateSalary()}");
        }
        else if (empType == "P")
        {
            PtEmp ptEmp = new PtEmp();
            Console.WriteLine("Enter Part Time Employee Details:");
            Console.Write("Enter Employee ID:");
            ptEmp.empId = int.Parse(Console.ReadLine());
            Console.Write("Basic Salary: ");
            ptEmp.basicSalary = double.Parse(Console.ReadLine());
            ptEmp.hra = ptEmp.basicSalary * 0.30;
            ptEmp.da = ptEmp.basicSalary * 0.10+;

            Console.WriteLine($"Part Time Employee Salary: {ptEmp.CalculateSalary()}");
        }
        else
        {
            Console.WriteLine("Invalid Employee Type");
        }
            Console.ReadKey();
        }
           
    }
}