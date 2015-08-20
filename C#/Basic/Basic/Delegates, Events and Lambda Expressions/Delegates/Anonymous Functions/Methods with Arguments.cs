/*
using System;

delegate void CountIt(int end);

class AnonMethDemo2
{
    static void Main()
    {
        CountIt count = delegate(int end)
        {
            for (int i = 0; i < end; i++)
                Console.WriteLine(i);
        };

        count(3);
        Console.WriteLine();
        count(5);
    }
}
*/