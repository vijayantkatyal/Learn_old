/*
// Use Out.

using System;

class Decompose
{
    // Decompose a floating-point value into its
    // integer and fractional parts.

    public int GetParts(double n,out double frac)
    {
        int whole = (int) n;
        frac = n - whole; // Pass Fractional part back through frac
        return whole; // Return integer portion.
    }
}

class UseOut
{
    static void Main()
    {
        Decompose ob = new Decompose();
        int i;
        double f;

        i = ob.GetParts(10.125, out f);

        Console.WriteLine("Integer portion is " + i);
        Console.WriteLine("Fractional part is " + f);
    }
}
*/