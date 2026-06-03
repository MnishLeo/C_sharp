using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.Delegate
{
    // Define a delegate that takes a string parameter and returns void
    public delegate void MyDelegate(string message);

    

    internal class Program
    {
        // Main method to demonstrate the use of the delegate
        public static void run(string[] args)
        {
            // Create an instance of the delegate and assign it the Hello method
            MyDelegate del = new MyDelegate(Hello);
            del("World");
            //delegate is a type safe function pointer bcz it can point to any method that matches its signature.
            //It is used to pass methods as arguments to other methods, to define callback methods, and to implement event handling in C#.
        }

        // A method that matches the signature of the delegate
        public static void Hello(string message)
        {
            Console.WriteLine("Hello, " + message);
        }

    }
}
