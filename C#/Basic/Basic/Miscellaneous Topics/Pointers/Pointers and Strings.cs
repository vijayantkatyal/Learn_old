/*
using System;

class FixedString
{
    unsafe static void Main()
    {
        string str = "this is a test";

        fixed (char* p = str)
        {
            for (int i = 0; p[i] != 0; i++)
                Console.Write(p[i]);
        }

        Console.WriteLine();
    }
}
*/