/*
using System;
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

// here is another Counter namespace.
namespace Counter
{
    class CountUp
    {
        int val;
        int target;
        public int Target
        {
            get { return target; }
        }

        public CountUp(int n)
        {
            target = n;
            val = 0;
        }

        public void Reset(int n)
        {
            target = n;
            val = 0;
        }

        public int Count()
        {
            if (val < target) return val++;
            else return target;
        }
    }
}

class NSDemo5
{
    static void Main()
    {
        CountDown cd = new CountDown(10);

        CountUp cu = new CountUp(8);
        int i;

        do
        {
            i = cd.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        do
        {
            i = cu.Count();
            Console.Write(i + " ");
        } while (i < cu.Target);
    }
}
*/