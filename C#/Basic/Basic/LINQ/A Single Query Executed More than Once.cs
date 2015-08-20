/*
using System;
using System.Linq;
using System.Collections.Generic;

class SimQuery
{
    static void Main()
    {
        int[] nums = { 1, -2, 3, 0, -4, 5 };

        var posNums = from n in nums
                      where n > 0
                      select n;

        Console.Write("The positive value in nums: ");

        foreach (int i in posNums) Console.Write(i + " ");
        Console.WriteLine();
        
        // Change Nums.
        Console.WriteLine("\nSetting nums[1] to 99.");
        nums[1] = 99;

        Console.Write("The positive value in nums after change: ");

        foreach (int i in posNums) Console.Write(i + " ");
        Console.WriteLine();
    }
}
*/