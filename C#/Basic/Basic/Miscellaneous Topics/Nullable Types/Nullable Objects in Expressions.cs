/*
using System;

class NullableDemo
{
    static void Main()
    {
        int? count = null;
        int? result = null;

        int incr = 10;

        result = count + incr;

        if (result.HasValue)
            Console.WriteLine("result has this value: " + result.Value);
        else
            Console.WriteLine("result has no value");

        count = 100;
        result = count + incr;

        if (count.HasValue)
            Console.WriteLine("result has this value: " + result.Value);
        else
            Console.WriteLine("result has no value");
    }
}
*/