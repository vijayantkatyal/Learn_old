/*
using System;
using System.Linq;

class ExtMethods2
{
    static void Main()
    {
        int[] nums = { 1, 2, 4, 8, 6, 9, 10, 3, 6, 7 };

        var ltAvg = from n in nums
                    let x = nums.Average()
                    where n < x
                    select n;

        Console.WriteLine("The Average is " + nums.Average());

        Console.WriteLine("These values are less than the average: ");
        foreach (int i in ltAvg) Console.Write(i + " ");
        Console.WriteLine();
    }
}
*/