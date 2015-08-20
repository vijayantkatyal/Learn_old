/*
using System;

delegate int CountIt(int end);

class AnonMethDemo3
{
    static void Main()
    {
        int result;

        CountIt count = delegate(int end)
        {
            int sum = 0;

            for (int i = 0; i <= end; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            return sum;
        };

        result = count(3);
        Console.WriteLine("Summation of 3 is " + result);
        Console.WriteLine();

        result = count(5);
        Console.WriteLine("Summation of 5 is " + result);
    }
}
*/