/*
// Indexers don't have to operate on actual arrays.

using System;

class PwrOfTwo
{

    int pwr(int p)
    {
        int result = 1;

        for (int i = 0; i < p; i++)
        {
            result *= 2;
        }
        return result;
    }

    public int this[int index]
    {
        get
        {
            if ((index >= 0) && (index < 16)) return pwr(index);
            else return -1;
        }
    }
}

class UsePwrOfTwo
{
    static void Main()
    {
        PwrOfTwo pwr = new PwrOfTwo();

        Console.Write("First 8 powers of 2: ");
        for (int i = 0; i < 8; i++)
            Console.Write(pwr[i] + " ");
        Console.WriteLine();

        Console.Write("Here are some errors: ");
        Console.Write(pwr[-1] + " " + pwr[17]);

        Console.WriteLine();
    }
}
*/