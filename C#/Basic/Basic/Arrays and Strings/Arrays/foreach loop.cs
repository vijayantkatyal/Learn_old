/*
// Use the foreach loop.

using System;

class Foreachdemo
{
    static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];

        // Give num some Values.
        for (int i = 0; i < 10; i++)
            nums[i] = i;

        // Use foreach to display and sum the values.
        foreach (int x in nums)
        {
            Console.WriteLine("Value is: " + x);
            sum += x;
        }
        Console.WriteLine("Summation : " + sum);
    }
}
*/