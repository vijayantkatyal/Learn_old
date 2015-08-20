/*
using System;

class ScopeDemo
{
    static void Main()
    {
        int x;
        x = 10;

        if (x == 10)
        {                       // New Scope.
            int y = 20;         // Only Known to this Scope/Block.
            Console.WriteLine("x and y: " + x + " " + y);
            x = y * 2;
        }
        //y = 100;  // y Not Known here.

        //x is still known here.
        Console.WriteLine("x is : " + x);
    }
}
*/