/*
using System;
using System.Threading;

class MyThread
{
    public int Count;
    string thrdName;

    public MyThread(string name)
    {
        Count = 0;
        thrdName = name;
    }

    // Entry Point of Thread
    public void Run()
    {
        Console.WriteLine(thrdName + " starting. ");

        do
        {
            Thread.Sleep(500);
            Console.WriteLine("In " + thrdName + ", Count is " + Count);
            Count++;
        }
        while (Count < 10);

        Console.WriteLine(thrdName + " terminating.");
    }
}

class MultiThread
{
    static void Main()
    {
        Console.WriteLine("Main thread starting.");

        // First, Construct a MyThread object.
        MyThread mt = new MyThread("Child #1");

        // Next, Construct a thread from object.
        Thread newThrd = new Thread(mt.Run);

        // Finally, start execution of the thread
        newThrd.Start();

        do
        {
            Console.WriteLine(".");
            Thread.Sleep(100);
        }
        while (mt.Count != 10);

        Console.WriteLine("Main thread ending.");

    }
}
*/