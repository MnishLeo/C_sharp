using System;
using System.Collections.Generic;
using System.Text;

namespace run.Inheritence
{
    public class Employee
    {
        public string fName;
        public string lName;


        public void printFullName()
        {
            Console.WriteLine(fName+ " " + lName);
        }

    }

    public class fullTimeEmployee : Employee
    {

        public float yearSalary;


    }
    public class partTimeEmployee : Employee
    {
        public float partTimeSalary;
    
    
    
    }

    public class Inheritence
    {
        public static void  run()
        {

            fullTimeEmployee fte = new fullTimeEmployee();
            fte.fName = "Alex";
            fte.lName = "Boss";
            fte.yearSalary = 440044f;
            fte.printFullName();    





        }

    }






}
