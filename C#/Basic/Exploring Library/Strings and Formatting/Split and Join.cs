/*
using System;

class SplitAndJoinDemo
{
    static void Main()
    {
        string str = "One if By land, two if by sea.";
        char[] seps = { ' ', '.', ',' };

        // Split strings into parts.
        string[] parts = str.Split(seps,StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Pieces from split: ");
        for (int i = 0; i < parts.Length; i++)
            Console.WriteLine(parts[i]);

        // Now, Join the parts.
        string whole = string.Join(" | ", parts);
        Console.WriteLine("Result of join: ");
        Console.WriteLine(whole);
    }
}
*/