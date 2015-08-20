/*
using System;

class PredDemo
{
    // A Predicate Method.
    // It Return true if v is negative.

    static bool IsNeg(int v)
    {
        if (v < 0) return true;
        return false;
    }

    static void Main()
    {
        int[] nums = { 1, 4, -1, 5, -9 };

        Console.Write("Contents of nums: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

        // First See if nums contain a negative value
        if (Array.Exists(nums, PredDemo.IsNeg))
        {
            Console.WriteLine("nums contains a negative value.");

            // Now find first negative value.
            int x = Array.Find(nums, PredDemo.IsNeg);
            Console.WriteLine("First negative value is: " + x);
        }
        else
        {
            Console.WriteLine("nums contains no negative values.");
        }
    }
}
*/