using System;
internal class Reverse
{
    internal void Digit()
    {
        Console.WriteLine("Enter the three digit number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int hundreds = num / 100;
        int tens = (num / 10) % 10;
        int ones = num % 10;
        int rev = ones * 100 + tens * 10 + hundreds * 1;
        Console.WriteLine($"Reversed Number is:{rev}");
    }
}