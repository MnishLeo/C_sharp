using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.Interface
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }


    public  class explicitInterface : I1 , I2
    {
        void I1.InterfaceMethod()
        {
           Console.WriteLine("Interface I1 method implementation");
        }

        void I2.InterfaceMethod()
        {
           Console.WriteLine("Interface I2 method implementation");
        }

        public static void run()
        {
            explicitInterface obj = new explicitInterface();
            // To call the I1 method, we need to cast the object to I1
            ((I1)obj).InterfaceMethod(); // Output: Interface I1 method implementation
            // To call the I2 method, we need to cast the object to I2
            ((I2)obj).InterfaceMethod(); // Output: Interface I2 method implementation

            //Or

            I1 i1 = new explicitInterface();
            I2 i2 = new explicitInterface();

            i1.InterfaceMethod(); // Output: Interface I1 method implementation
            i2.InterfaceMethod(); // Output: Interface I2 method implementation 


        }
         
    }
}
