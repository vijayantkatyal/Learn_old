/*
// use the global alias.

using System;
using Ctr = Counter;


namespace Counter
{
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }

        // ...
    }
}

// global namespace.

class CountDown
{
    int val;

    public CountDown(int n)
    {
        val = n;
    }

    // ...
}

class GlobalAliasQualifierDemo
{
    static void Main()
    {
        Ctr::CountDown cd1 = new Ctr::CountDown(10);

        // using global namespace.
        global::CountDown cd2 = new global::CountDown(10);
    }
}
*/