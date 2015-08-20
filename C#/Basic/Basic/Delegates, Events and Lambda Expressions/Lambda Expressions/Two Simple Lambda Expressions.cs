/*
using System;

delegate int Incr(int v);

delegate bool IsEven(int v);

class SimpleLambdaDemo
{
    static void Main()
    {
        Incr incr = count=> count + 2; // increase parameter by 2.

        Console.WriteLine("Use incr lambda expression: ");
        int x = -10;
        while (x <= 0)
        {
            Console.Write(x + " ");
            x = incr(x); // increase x by 2.
        }

        Console.WriteLine("\n");


        IsEven isEven = n => n % 2 == 0; // return true if n is even.

        Console.WriteLine("Use isEven lambda expression: ");
        for (int i = 1; i <= 10; i++)
            if (isEven(i)) Console.WriteLine(i + " is even.");
    }
}
*/