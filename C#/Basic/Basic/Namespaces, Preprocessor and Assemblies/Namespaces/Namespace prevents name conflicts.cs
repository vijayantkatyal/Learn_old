/*
using System;

// Declare Counter namespace.

namespace Counter
{
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }

        public void Reset(int n)
        {
            val = n;
        }

        public int Count()
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}

// Decalre Counter2 namespace.
namespace Counter2
{
    class CountDown
    {
        public void Count()
        {
            Console.WriteLine("This is Count2() in the Counter2 namespace.");
        }
    }
}

class NSDemo2
{
    static void Main()
    {
        // This is CountDown in Counter Namespace.
        Counter.CountDown cd1 = new Counter.CountDown(10);

        // This is CountDown in Counter2 Namespace.
        Counter2.CountDown cd2 = new Counter2.CountDown();

        int i;

        do
        {
            i = cd1.Count();
            Console.Write(i + " ");
        }
        while (i > 0);
        Console.WriteLine();

        cd2.Count();
    }
}
*/