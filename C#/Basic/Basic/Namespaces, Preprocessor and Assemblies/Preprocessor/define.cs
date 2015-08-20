/*
// Demonstrate #if , #endif and #define.

#define EXPERIMENTAL
#define TRIAL
#define RELEASE
using System;

class Test
{
    static void Main()
    {
        #if EXPERIMENTAL
        Console.WriteLine("Compiled for experimental version.");
        #elif RELEASE
        Console.WriteLine("Compiled for Release.");
        #else
        Console.WriteLine("Compiled for testing.");
        #endif
        
        #if TRIAL && EXPERIMENTAL
        Console.WriteLine("Testing experimental trial version");
        #endif
        Console.WriteLine("This is in all version.");
    }
}
*/