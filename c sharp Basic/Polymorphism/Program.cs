using System;
using System.Collections.Generic;
using System.Text;

namespace run.Polymorphism
{

    public class Employee
    {
        public string firstName = "Fn";
        public string lastName = "Ln";
        public virtual void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void printFullName()
        {
           Console.WriteLine(firstName + " " + lastName + " - FullTime");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - PartTime");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void printFullName()
        {
           Console.WriteLine(firstName + " " + lastName + " - Temporary");
        }
    }


    public class Program
    {
        public static void run()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee emp in employees)
            {
                emp.printFullName();
            }
        }
    }

}