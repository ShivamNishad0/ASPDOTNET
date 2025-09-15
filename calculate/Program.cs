using System;

public class Calculate
{

    public static void Main(string[] args)
    {
        // Operation obj = new Operation();
        // obj.Accept();
        // obj.Add();
        // obj.Sub();
        // obj.Mul();
        // obj.Div();

        SimpleIntrest obj = new SimpleIntrest();
        obj.Calsi();
        Compound obj1 = new Compound();
        obj1.Interest();
        Area obj2 = new Area();
        obj2.Circle();
        obj2.Triangle();
        Converts.Converting();
        Reverse obj3 = new Reverse();
        obj3.Digit();
    }
}