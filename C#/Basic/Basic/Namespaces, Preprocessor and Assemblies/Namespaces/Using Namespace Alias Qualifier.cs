/*
// Demonstrate why the :: quantifier is needed.
// This Program will not Compile.

using System;
using Counter;
using AnotherCounter;

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

namespace AnotherCounter
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

class WhyAliasQuantifier
{
    static void Main()
    {
        int i;

        CountDown cd1 = new CountDown(10); // Error !!! Ambiguity.
    }
}

*/