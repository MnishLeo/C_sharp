using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.Interface
{

    interface IA
    {
        void Aprint();
    }

    class A : IA
    {
        public void Aprint()
        {
            Console.WriteLine("Print Method A");
        }
    }

    interface IB
    {
        void Bprint();

    }
    class B : IB
    {
        public void Bprint()
        {
            Console.WriteLine("Print Method B");
        }
    }

    class AB: IA, IB
    {
        A a = new A();
        B b = new B();

        public void Aprint()
        {
            a.Aprint();
        }
        public void Bprint()
        {
            b.Bprint();
        }   

    }


    internal class Class1
    {
        public static void run(string[] args)
        {
            AB ab = new AB();
            ab.Aprint();
            ab.Bprint();
        }


    }
}
