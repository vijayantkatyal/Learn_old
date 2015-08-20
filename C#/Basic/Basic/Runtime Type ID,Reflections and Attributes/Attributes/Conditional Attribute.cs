/*
#define TRIAL

using System;
using System.Diagnostics;

class Test
{
    [Conditional("TRIAL")]
    void Trial()
    {
        Console.WriteLine("Trial Version, not for distribution.");
    }

    [Conditional("RELEASE")]
    void Release()
    {
        Console.WriteLine("Final release version.");
    }


    static void Main()
    {
        Test t = new Test();

        t.Trial();
        t.Release();
    }
}
*/