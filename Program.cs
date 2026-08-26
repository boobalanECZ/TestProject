using System;
using System.Collections.Generic;

namespace SampleProject
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== Employee Management System =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;

                    case "2":
                        ViewEmployees();
                        break;

                    case "3":
                        Console.WriteLine("Application closed.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        Pause();
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Console.Clear();

            Console.WriteLine("===== Add Employee =====");

            Console.Write("Enter Employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Employee employee = new Employee(
                employeeId,
                employeeName,
                department,
                salary
            );

            employees.Add(employee);

            Console.WriteLine();
            Console.WriteLine("Employee added successfully.");

            Pause();
        }

        static void ViewEmployees()
        {
            Console.Clear();

            Console.WriteLine("===== Employee List =====");

            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                Pause();
                return;
            }

            foreach (Employee employee in employees)
            {
                employee.DisplayEmployee();
            }

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}