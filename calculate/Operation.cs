using System;
public class Operation
{
    int a, b, c;
    public void Accept()
    {
        Console.WriteLine("Enter the Number to Calculate");
        Console.WriteLine("Enter the value of A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of B");
        b = Convert.ToInt32(Console.ReadLine());
    }
    public void Add() {
        Console.WriteLine("Addition of the A and B is:- ");
        c = a + b;
        Console.WriteLine(c);
    }
    public void Sub() {
        Console.WriteLine("Substract of the A and B is:- ");
        c = a - b;
        Console.WriteLine(c);
    }
    public void Mul() {
        Console.WriteLine("Multiply of the A and B is:- ");
        c = a * b;
        Console.WriteLine(c);
    }
    public void Div() {
        Console.WriteLine("Division of the A and B is:- ");
        c = a / b;
        Console.WriteLine(c);
    }
}