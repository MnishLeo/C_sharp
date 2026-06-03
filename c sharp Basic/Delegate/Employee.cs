using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.Delegate
{
    // Define a delegate that takes an Employee object and returns a boolean
    delegate bool IsPromotable(Employee emp);

    // Employee class with properties and a method to promote employees based on the delegate
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public int age { get; set; }
        public int experience { get; set; }

        public int salary { get; set; }

        // Method to promote employees based on the IsPromotable delegate
        public static void PromoteEmployee(List<Employee> employee, IsPromotable isEligibleForPromotion)
        {
            // Iterate through the list of employees and check if they are eligible for promotion
            foreach (Employee emp in employee)
            {
                // If the employee is eligible for promotion, print their name
                if (isEligibleForPromotion(emp))
                {
                    Console.WriteLine(emp.name + " promoted");
                }
            }
        }


        // Main method to create a list of employees and promote them based on their experience
        public static void Main(string[] args)
        {
            // Create a list of employees with their details
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { id = 1, name = "John", age = 25, experience = 3, salary = 50000 });
            employeeList.Add(new Employee() { id = 2, name = "Jane", age = 30, experience = 5, salary = 60000 });
            employeeList.Add(new Employee() { id = 3, name = "Bob", age = 35, experience = 10, salary = 70000 });

            //  Create an instance of the IsPromotable delegate and pass the Promote method as a parameter
            // The Promote method will be used to determine if an employee is eligible for promotion based on their experience
            IsPromotable isPromotable = new IsPromotable(Promote);

            // Call the PromoteEmployee method and pass the list of employees and the IsPromotable delegate to promote eligible employees
            Employee.PromoteEmployee(employeeList, isPromotable);


        }

        // Method to determine if an employee is eligible for promotion based on their experience
        public static bool Promote(Employee emp)
        {
            // If the employee has 5 or more years of experience, they are eligible for promotion
            if (emp.experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
