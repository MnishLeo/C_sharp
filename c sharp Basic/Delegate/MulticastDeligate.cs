using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace c_sharp_Basic.Delegate
{
    public delegate void SampleDelegate(out int Integer);

    // public delegate void SampleDelegate();

    // Multicast delegates are delegates that can have more than one method assigned to them.
    // When a multicast delegate is invoked, it calls all the methods that are assigned to it in the order they were added. This allows you to execute multiple methods with a single delegate invocation,
    // making it useful for scenarios like event handling or when you want to perform multiple actions in response to a single event.
    internal class MulticastDeligate
    {
        public static void run()
        {
            //    // Create instances of the SampleDelegate and assign methods to them
            //    SampleDelegate del1, del2, del3, del4;

            //    // Assign methods to the delegates
            //    del1 = new SampleDelegate(SampleDelegateMethod1);
            //    del2= new SampleDelegate(SampleDelegateMethod2);
            //    del3= new SampleDelegate(SampleDelegateMethod3);

            //    // Combine the delegates to create a multicast delegate
            //    del4 = del1 + del2 + del3;
            //    del4();


            //}
            //// Sample methods to be assigned to the delegates
            //public static void SampleDelegateMethod1()
            //{
            //    Console.WriteLine("Delegate Method 1");
            //}
            //public static void SampleDelegateMethod2()
            //{
            //    Console.WriteLine("Delegate Method 2");
            //}
            //public static void SampleDelegateMethod3()
            //{
            //    Console.WriteLine("Delegate Method 3");


            
            SampleDelegate del = new SampleDelegate(SampleDelegateMethod1);

            // Add another method to the delegate
            del += SampleDelegateMethod2;

            // Invoke the multicast delegate
            int DelegateOutputParaeteValue = -1;

            // Since the delegate has an out parameter, we need to declare a variable to hold the output value.
            del(out DelegateOutputParaeteValue);

            Console.WriteLine($"Delegate Output Parameter Value: {DelegateOutputParaeteValue}");

        }
        // Sample methods to be assigned to the delegates
        public static void SampleDelegateMethod1(out int Number)
        {
            Number = 1;
        }
        // Note: When invoking a multicast delegate with an out parameter, only the last method in the invocation list will set the value of the out parameter.
        public static void SampleDelegateMethod2(out int Number)
        {
            Number = 2;
        }
    }
}
