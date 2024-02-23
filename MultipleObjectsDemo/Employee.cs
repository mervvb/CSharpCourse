using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleObjectsDemo
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public int SalaryPerHour;

        public int NoOfWorkingHours;
        public static string OrganizationName { get; set; }

        public const string TypeOfEmployee = "Contract Based";

        public readonly string DepartmentName = "Finance Department";

        public int NetSalary(int NoOfWorkingHours, int SalaryPerHour)
        {
            return (SalaryPerHour * NoOfWorkingHours);
        }
    }
}
