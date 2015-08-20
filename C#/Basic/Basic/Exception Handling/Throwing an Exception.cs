/*
// Manually throw an exception.

using System;

class ThrowDemo
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Before throw.");
            throw new DivideByZeroException();
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Exception Caught");
        }
        Console.WriteLine("After try/catch statement");
    }
}
*/