﻿/*
using System;

class RangeArray
{
    int[] a;
    int lowerbound;
    int upperbound;

    public int Length { get; private set; }

    public bool Error { get; private set; }

    public RangeArray(int low,int high)
    {
        high++;
        if (high <= low)
        {
            Console.WriteLine("Invalid Indices");
            high = 1;
            low = 0;
        }

        a = new int[high - low];
        Length = high - low;

        lowerbound = low;
        upperbound = --high;
    }

    private bool ok(int index)
    {
        if (index >= lowerbound & index <= upperbound) return true;
        return false;
    }

    public int this[int index]
    {
        get
        {
            if (ok(index))
            {
                Error = false;
                return a[index - lowerbound];
            }
            else
            {
                Error = true;
                return 0;
            }
        }
        set
        {
            if (ok(index))
            {
                a[index - lowerbound] = value;
                Error = false;
            }
            else
            {
                Error = true;
            }
        }
    }

}

class RangeArrayDemo
{
    static void Main()
    {
        RangeArray ra = new RangeArray(-5, 5);
        RangeArray ra2 = new RangeArray(1, 10);
        RangeArray ra3 = new RangeArray(-20, -12);

        Console.WriteLine("Length of ra: " + ra.Length);

        for (int i = -5; i <= 5; i++)
            ra[i] = i;

        Console.Write("Contents of ra: ");
        for (int i = -5; i <= 5; i++)
            Console.Write(ra[i] + " ");

        Console.WriteLine("\n");

        Console.WriteLine("Length of ra2: " + ra2.Length);

        for (int i = 1; i <= 10; i++)
            ra2[i] = i;

        Console.Write("Contents of ra2: ");
        for (int i = 1; i <= 10; i++)
            Console.Write(ra2[i] + " ");

        Console.WriteLine("\n");

        Console.WriteLine("Length of ra3: " + ra3.Length);

        for (int i = -20; i <= -12; i++)
            ra3[i] = i;

        Console.Write("Contents of ra3: ");
        for (int i = -20; i <= -12; i++)
            Console.Write(ra3[i] + " ");

        Console.WriteLine();

    }
}
*/