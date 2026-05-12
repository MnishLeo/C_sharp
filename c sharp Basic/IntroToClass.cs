using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic;

class IntroToClass()
{
    public static void Run()
    {
        Customer c1 = new Customer("Rohan", "Partap");
        c1.printFullName();
    }
}
class Customer
{

    string fName;
    string lName;

    public Customer(string firstName, string lastName)
    {
        this.fName = firstName;
        this.lName = lastName;
    }



    public void printFullName()
    {
        Console.WriteLine("Full Name = {0}", this.fName + " " + this.lName);
    }


    //DeConstruct
    ~Customer()
    {
        //clean up code 
    }




    

}
    

