/*
using System;

class CopyDemo
{
    static void Main()
    {
        int[] source = { 1, 2, 3, 4, 5 };
        int[] target = { 11, 12, 13, 14, 15 };
        int[] source2 = { -1, -2, -3, -4, -5 };

        // Display Source.
        Console.Write("source: ");
        foreach (int i in source)
            Console.Write(i + " ");
        Console.WriteLine();

        // Display Original target
        Console.Write("original contents of target: ");
        foreach (int i in source2)
            Console.Write(i + " ");
        Console.WriteLine();

        // Copy entire Array.
        Array.Copy(source, target, source.Length);

        // Display Copy
        Console.Write("target after copy: ");
        foreach (int i in target)
            Console.Write(i + " ");
        Console.WriteLine();

        // Copy into middle of target.
        Array.Copy(source2, 2, target, 3, 2);

        // Display Copy
        Console.Write("target after copy: ");
        foreach (int i in target)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
*/