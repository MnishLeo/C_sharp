namespace run.Inheritence
{
    using System;

    public class Employee1
    {
        public string firstName;
        public string lastName;

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee1
    {
        public new void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }

    public class PartTimeEmployee : Employee1
    {
        // PartTimeEmployee inherits Employee1's printFullName
    }

    public class MethodHiding
    {
        public static void Main()
        {
            FullTimeEmployee employee = new FullTimeEmployee();
            employee.firstName = "Gog";
            employee.lastName = "Don";
            employee.printFullName(); // Outputs: Gog Don - Contractor
        }
    }
}