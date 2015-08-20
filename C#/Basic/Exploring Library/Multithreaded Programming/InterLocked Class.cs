/*
using System;
using System.Threading;

class SharedRes
{
    public static int Count = 0;
}

class IncThread
{
    public Thread Thrd;

    public IncThread(string name)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            Interlocked.Increment(ref SharedRes.Count);
            Console.WriteLine(Thrd.Name + " Count is " + SharedRes.Count);
        }
    }
}

class DecThread
{
    public Thread Thrd;

    public DecThread(string name)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            Interlocked.Decrement(ref SharedRes.Count);
            Console.WriteLine(Thrd.Name + " Count is " + SharedRes.Count);
        }
    }
}

class InterlockedDemo
{
    static void Main()
    {
        IncThread mt1 = new IncThread("Increment Thread");
        DecThread mt2 = new DecThread("Decrement Thread");

        mt1.Thrd.Join();
        mt2.Thrd.Join();
    }
}
*/