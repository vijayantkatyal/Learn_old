/*
// Demonstrate the short-circuit operators.
using System;

class SCops
{
    static void Main()
    {
        int n, d;

        n = 10;
        d = 2;

        if (d != 0 && (n % d) == 0)
        {
            Console.WriteLine(d + " is factor of " + n);
        }

        d = 0; //Now set , d to zero.
        // As d is zero , the second operand is not evaluated.

        if (d != 0 && (n % d) == 0)
        {
            Console.WriteLine(d + " is factor of " + n);
        }

        // Now try Same Thing without Short-Circuit Operator.
        // This will cause divide-by-zero error.

        if (d != 0 & (n % d) == 0)
        {
            Console.WriteLine(d + " is factor of " + n);
        }
    }
}
*/