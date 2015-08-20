/*
using System;
using Counter;
using AnotherCounter;
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

class AliasQuanlifierDemo
{
    static void Main()
    {
        // Here , the :: Operator. Tells the Compiler to use CountDown that
        // is in the Counter namespace.
        Ctr::CountDown cd1 = new Ctr::CountDown(10);
    }
}
*/