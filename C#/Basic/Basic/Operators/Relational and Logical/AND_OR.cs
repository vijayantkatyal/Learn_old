/*
using System;

class SideEffects
{   
    static void Main()
    {
        int i;
        bool somecondition = false;

        i = 0;
        // here , i still incremented even though the if statement fails.

        if (somecondition & (++i < 100))
            Console.WriteLine("this won't be displayed.");
        Console.WriteLine("if statement executed" + i);
        

        // in this case , i is not incremented because short-circuit skip the case.
        if (somecondition && (++i < 100))
            Console.WriteLine("this won't be displayed");
        Console.WriteLine("if statement executed" + i); //Still 1 !!
    }
}
*/