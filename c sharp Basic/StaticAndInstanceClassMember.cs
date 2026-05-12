using System;
using System.Collections.Generic;
using System.Text;

namespace run
{
   class Circle
    {
        static float _PI = 3.141f;
        int _Radius;

public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public float ClacArea()
    {
        return Circle._PI * this._Radius * this._Radius;

    }
    ~Circle()
    {
        //Clean up Code
    }
static void Run(string[] args)
{
    Circle c1 = new Circle(5);
    float Area = c1.ClacArea();
    Console.WriteLine("Area {0}", Area);

    Circle c2 = new Circle(6);
    float Area2 = c2.ClacArea();
    Console.WriteLine("Area {0}", Area2);

}
    }
}
