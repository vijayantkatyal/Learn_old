/*
using System;

class CheckedDemo
{
    static void Main()
    {
        byte a, b;
        byte result;

        a = 127;
        b = 127;

        try
        {
            result = unchecked((byte)(a * b));
            Console.WriteLine("UnChecked result: " + result);

            result = checked((byte)(a * b)); // this cause exception.
            Console.WriteLine("Checked result " + result); // won't execute.
        }
        catch(OverflowException exc)
        {
            Console.WriteLine(exc);
        }
    }
}
*/