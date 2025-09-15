using System;

public class Calculate
{
    int a, b, c;
    void Accept()
    {
        Console.WriteLine("Enter the Number to Calculate");
        Console.WriteLine("Enter the value of A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of B");
        b = Convert.ToInt32(Console.ReadLine());
    }
    void Add() {
        Console.WriteLine("Addition of the A and B is:- ");
        c = a + b;
        Console.WriteLine(c);
    }
    void Sub() {
        Console.WriteLine("Substract of the A and B is:- ");
        c = a - b;
        Console.WriteLine(c);
    }
    void Mul() {
        Console.WriteLine("Multiply of the A and B is:- ");
        c = a * b;
        Console.WriteLine(c);
    }
    void Div() {
        Console.WriteLine("Division of the A and B is:- ");
        c = a / b;
        Console.WriteLine(c);
    }
    public static void Main(string[] args)
    {
        Calculate obj = new Calculate();
        obj.Accept();
        obj.Add();
        obj.Sub();
        obj.Mul();
        obj.Div();

    }
}