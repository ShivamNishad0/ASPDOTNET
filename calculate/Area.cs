using System;

internal class Area
{

    internal void Circle()
    {
        float a, r=15, pi = 3.1419F;
        a = pi * r * r;
        Console.WriteLine("Area of circle is:{0}",a);

        }
    internal void Triangle()
    {
        float a, b=20, h=30;
        a = 1 / 2 * (b * h);
        Console.WriteLine("Area of triangle is:{0}", a);
            
        }
    
}