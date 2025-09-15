using System;

internal class Memory
{
    static int y = 100; //Global
    int a = 10;  //instance variable so if we have to use this. First we have to create the object of that the call it...
    static void Main(string[] args)
    {
        int y = 20; // Beacouse this in under the static function....
        y = 30;
        Console.WriteLine("Static variable is: " + y);
        Console.WriteLine("Static Global variable is: " + Memory.y);
        Memory obj = new Memory();
        Console.WriteLine("Instance variable is: " + obj.a);
        const string name = "Shivam Nishad"; // Constant variable mean this value can't be changed 
        Console.WriteLine(name);
        Swap.Swaping();
    }
}