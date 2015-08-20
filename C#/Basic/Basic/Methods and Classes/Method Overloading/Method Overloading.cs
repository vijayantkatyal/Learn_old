/*
// Demonstrate Method Overloading.

using System;

class Overload
{
    public void OvlDemo()
    {
        Console.WriteLine("No parameters");
    }

    public void OvlDemo(int a)
    {
        Console.WriteLine("One Parameter: " + a);
    }

    public int OvlDemo(int a,int b)
    {
        Console.WriteLine("Two Parameter: " + a + " " + b);
        return a + b;
    }

    public double OvlDemo(double a, double b)
    {
        Console.WriteLine("Two double Parameter: " + a + " " + b);
        return a + b;
    }
}

class OverloadDemo
{
    static void Main()
    {
        Overload ob = new Overload();
        int resI;
        double resD;

        ob.OvlDemo();
        Console.WriteLine();

        ob.OvlDemo(2);
        Console.WriteLine();

        resI = ob.OvlDemo(4, 6);
        Console.WriteLine("Result of ob.OvlDemo(4,6): " + resI);
        Console.WriteLine();

        resD = ob.OvlDemo(1.1, 2.32);
        Console.WriteLine("Result of ob.OvlDemo(1.1,2.32): " + resD);
        Console.WriteLine();
    }
}
*/