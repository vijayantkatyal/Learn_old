/*
using System;
using System.Linq;

class SelectDemo
{
    static void Main()
    {
        double[] nums = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5 };

        var sqrRoots = from n in nums
                       where n > 0
                       select Math.Sqrt(n);

        Console.WriteLine("The Square roots of the positive values" + " rounded to two decimal places: ");
        foreach (double r in sqrRoots) Console.WriteLine("{0:#.##}", r);
    }
}
*/