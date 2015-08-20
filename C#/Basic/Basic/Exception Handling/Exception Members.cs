﻿/*
// Using Exception Members.

using System;

class ExcTest
{
    public static void GenException()
    {
        int[] nums = new int[4];

        Console.WriteLine("Before Exception is Generated");

        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
        }
        Console.WriteLine("this won't be displayed");
    }
}

class UseExcept
{
    static void Main()
    {
        try
        {
            ExcTest.GenException();
        }
        catch (IndexOutOfRangeException exc)
        {
            Console.WriteLine("Standard message is: ");
            Console.WriteLine(exc);
            Console.WriteLine("Stack trace: " + exc.StackTrace);
            Console.WriteLine("Message: " + exc.Message);
            Console.WriteLine("TargetSite: " + exc.TargetSite);
        }
        Console.WriteLine("After catch block.");
    }
}
*/