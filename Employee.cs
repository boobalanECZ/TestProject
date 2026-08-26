using System;

namespace SampleProject
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(int employeeId, string employeeName, string department, decimal salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Department = department;
            Salary = salary;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Department    : " + Department);
            Console.WriteLine("Salary        : " + Salary);
            Console.WriteLine("--------------------------------");
        }
    }
}