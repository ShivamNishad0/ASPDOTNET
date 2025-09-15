using System;


internal class Swap
{
    static int a = 10, b = 20;

    internal static void Swaping()
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("value of a={0} and b={1}", a, b);
    }
}