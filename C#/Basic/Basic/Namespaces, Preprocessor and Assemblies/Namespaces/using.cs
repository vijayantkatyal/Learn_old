/*
using System;

// Bring Counter into view.
using Counter;

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

class NSDemo3
{
    static void Main()
    {
        CountDown cd1 = new Counter.CountDown(10);
        int i;

        do
        {
            i = cd1.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        CountDown cd2 = new Counter.CountDown(20);

        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        cd2.Reset(4);
        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
    }
}
*/