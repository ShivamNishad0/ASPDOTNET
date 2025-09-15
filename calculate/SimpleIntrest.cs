using System;
public class SimpleIntrest
{
    float p, r, t, si;
    internal void Calsi()
    {
        p = 10000;
        r = 7.56F;
        t = 5;
        si = (p * r * t) / 100;
        Console.WriteLine("Simple Interest is {0}", si);
    }

}