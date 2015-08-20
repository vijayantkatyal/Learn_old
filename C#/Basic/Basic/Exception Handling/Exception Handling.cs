﻿/*
// Demonstrate Exception Handling.

using System;

class ExcDemo1
{
    static void Main()
    {
        int[] nums = new int[4];

        try
        {
            Console.WriteLine("Before exception is generated");

            // Generate an index out-of-bounds exception.
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }
            Console.WriteLine("this won't be displayed");
        }
        catch(IndexOutOfRangeException)
        {
            // Catch Exception
            Console.WriteLine("Index out-of-bounds!");
        }
        Console.WriteLine("After catch Block.");
    }
}
*/