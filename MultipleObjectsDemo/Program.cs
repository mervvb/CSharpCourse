using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleObjectsDemo
{
    public class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();

            Console.Write("Employee Name: ");
            employee1.EmpName = Console.ReadLine();
            Console.WriteLine(employee1.EmpName);

            Console.WriteLine("*************");

            Console.Write("Employee Id: ");
            employee1.EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(employee1.EmpID);


            Console.WriteLine("*************");

            Console.Write("SalaryPerHour: ");
            employee1.SalaryPerHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(employee1.SalaryPerHour);


            Console.WriteLine("*************");

            Console.Write("Working Hours: ");
            employee1.NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(employee1.NoOfWorkingHours);


            Console.WriteLine("*************");

            int netSalary = employee1.NetSalary(employee1.NoOfWorkingHours, employee1.SalaryPerHour);
            Console.WriteLine("Net Salary: " + netSalary);
            Employee.OrganizationName = "Harsha Inc";
            Console.WriteLine("Department name: " + employee1.DepartmentName);
            Console.WriteLine("Organization name: " + Employee.OrganizationName);
            Console.WriteLine("Type of employee: " + Employee.TypeOfEmployee);


            Console.WriteLine("*************");


            Employee employee2 = new Employee();

            for (int j = 1; j < 10; j++)
            {
                Console.Write("Do you want to continue to next employee?: ");

                string answer = Console.ReadLine();


                if (answer == "Yes")
                {
                    Console.Write("ID: ");
                    employee2.EmpID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Employee Name: ");
                    employee2.EmpName = Console.ReadLine();
                    Console.Write("SalaryPerHour: ");
                    employee2.NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Working Hours: ");
                    employee2.SalaryPerHour = Convert.ToInt32(Console.ReadLine());
                    netSalary = employee2.NetSalary(employee2.NoOfWorkingHours, employee2.SalaryPerHour);
                    Console.WriteLine("Net Salary: " + netSalary);
                    Console.WriteLine("Type of employee: " + Employee.TypeOfEmployee);
                    Console.WriteLine("Department name: " + employee2.DepartmentName);
                    Employee.OrganizationName = "Harsha Inc";
                    Console.WriteLine("Organization name: " + Employee.OrganizationName);

                }
                else { Console.WriteLine("Done!"); }
                Console.ReadLine();
            }



        }


    }
}







