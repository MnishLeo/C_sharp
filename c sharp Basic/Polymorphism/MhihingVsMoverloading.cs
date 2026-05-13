using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.Polymorphism
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("BaseClass print method");
        }


        public class DerivedClassPrint() : BaseClass
        {
            //with new keyword we are hiding the base class method and creating a new method in derived class with same name and signature
            public new void Print()
            {
                Console.WriteLine("BaseClass DerivedClassPrint method");
            }

        }

        public class MhihingVsMoverloading
        {
            public static void run(string[] args)
            {
                BaseClass baseObj = new DerivedClassPrint();
                baseObj.Print();
            }
        }
    }
}
