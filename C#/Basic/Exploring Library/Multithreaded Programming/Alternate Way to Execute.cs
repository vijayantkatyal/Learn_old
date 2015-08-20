/*
using System;
using System.Threading;

class MyThread
{
    public int Count;
    public Thread Thrd;

    public MyThread(string name)
    {
        Count = 0;
        Thrd = new Thread(this.Run);
        Thrd.Name = name; // Set name of the thread
        Thrd.Start(); // Start the  thread
    }

    // Entry point of thread
    void Run()
    {
        Console.WriteLine(Thrd.Name + " starting.");

        do
        {
            Thread.Sleep(500);
            Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);
            Count++;
        }
        while (Count < 10);

        Console.WriteLine(Thrd.Name + " terminating");
    }
}

class MultiThreadImproved
{
    static void Main()
    {
        Console.WriteLine("Main Thread starting.");

        // First Construct a MyThreadObject.
        MyThread mt = new MyThread("Child #1");

        do
        {
            Console.WriteLine(".");
            Thread.Sleep(100);
        }
        while (mt.Count != 10);

        Console.WriteLine("Main Thread ending.");
    }
}
*/