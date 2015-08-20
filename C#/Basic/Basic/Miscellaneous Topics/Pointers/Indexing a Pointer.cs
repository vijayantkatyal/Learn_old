/*
using System;

class PtrIndexDemo
{
    unsafe static void Main()
    {
        int[] nums = new int[10];
        // Index a pointer.
        Console.WriteLine("Index pointer like array.");
        fixed (int* p = nums)
        {
            for (int i = 0; i < 10; i++)
                p[i] = i; // index pointer like array
            for (int i = 0; i < 10; i++)
                Console.WriteLine("p[{0}]: {1} ", i, p[i]);
        }
        // Use pointer arithmetic.
        Console.WriteLine("\nUse pointer arithmetic.");
        fixed (int* p = nums)
        {
            for (int i = 0; i < 10; i++)
                *(p + i) = i; // use pointer arithmetic
            for (int i = 0; i < 10; i++)
                Console.WriteLine("*(p+{0}): {1} ", i, *(p + i));
        }
    }
}
*/