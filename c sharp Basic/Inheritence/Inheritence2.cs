using run.Inheritence;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace run.Inheritence
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Derived Class Controlling parent class");
        }

        public Parent(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class Child : Parent
    {
        public Child() : base("Parent class Parameter constructor called")
        {

            Console.WriteLine("Child class Constructor called");
        }




    }



}


    public class Inheritence2()
    {

        public static void run()
            {
        Child ch = new Child();

            }
}



