
using System;

class Program
{
    static void Main()
    {
        //creat objects for class employee
        Employee employee1 = new Employee(101, "Scott", 'a');
        Employee employee2 = new Employee(102, "Mary", 'c');
        Employee employee3 = new Employee(103, "Gabriel");
        Employee employee4 = new Employee();
        Employee employee = new Employee { EmpId = 10, EmpName = "Sofia", JobCode = 'g' }; //object initializer

        //display fields

        Console.WriteLine(Employee.CompanyName);

        Console.WriteLine(employee.EmpId);
        Console.WriteLine(employee.EmpName);
        Console.WriteLine(Convert.ToInt32(employee.JobCode));
        Console.WriteLine();

        Console.WriteLine("\n::First Employee::");
        Console.WriteLine(employee1.EmpId);
        Console.WriteLine(employee1.EmpName);
        Console.WriteLine(Convert.ToInt32(employee1.JobCode));
        Console.WriteLine("Default Id: " + employee4.EmpId);
        Console.WriteLine();

        Console.WriteLine("::Second Employee::");
        Console.WriteLine(employee2.EmpId);
        Console.WriteLine(employee2.EmpName);
        Console.WriteLine(Convert.ToInt32(employee2.JobCode));
        Console.WriteLine();

        Console.WriteLine("::Third Employee::");
        Console.WriteLine(employee3.EmpId);
        Console.WriteLine(employee3.EmpName);
        Console.WriteLine(Convert.ToInt32(employee3.JobCode));
        Console.WriteLine();

        Console.ReadLine();

    }
}