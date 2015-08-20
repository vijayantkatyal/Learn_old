/*
using System;

delegate int IntOp(int end);

class StatementLambdaDemo
{
    static void Main()
    {
        IntOp fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                    r = i * r;
                return r;
            };

        Console.WriteLine("The Factorial of 3 is " + fact(3));
        Console.WriteLine("The Factorial of 5 is " + fact(5));
    }
}
*/