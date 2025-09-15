using System;
internal class Converts
{
    static float feet, inch=50;
    internal static void Converting()
    {
        feet = Convert.ToInt32(inch / 12f);
        Console.WriteLine("Converted feet to inch value is:{0}", feet);

    }
}