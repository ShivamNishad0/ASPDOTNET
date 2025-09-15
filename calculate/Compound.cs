using System;

internal class Compound
{
    internal void Interest()
    {
        float p = 50000, r = 3.5F, n = 5;
        // Convert to double for Math.Pow, then back to float if desired
        double amount = p * Math.Pow(1 + (r / 100), n);
        double ci = amount - p;

        Console.WriteLine("Compound Interest = " + ci);

    }
}


