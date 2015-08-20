/*
using System;
using System.Threading;
using System.Runtime.CompilerServices;

class TickTock
{
    [MethodImplAttribute(MethodImplOptions.Synchronized)]
    public void Tick(bool running)
    {
        if (!running)
        {
            Monitor.Pulse(this);
            return;
        }

        Console.Write("Tick ");
        Monitor.Pulse(this);

        Monitor.Wait(this);
    }

    [MethodImplAttribute(MethodImplOptions.Synchronized)]
    public void Tock(bool running)
    {
        if (!running)
        {
            Monitor.Pulse(this);
            return;
        }

        Console.WriteLine("Tock");
        Monitor.Pulse(this);
        Monitor.Wait(this);
    }
}

class MyThread
{
    public Thread Thrd;
    TickTock ttOb;

    public MyThread(string name,TickTock tt)
    {
        Thrd = new Thread(this.Run);
        ttOb = tt;
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        if (Thrd.Name == "Tick")
        {
            for (int i = 0; i < 5; i++) ttOb.Tick(true);
            ttOb.Tick(false);
        }
        else
        {
            for (int i = 0; i < 5; i++) ttOb.Tock(true);
            ttOb.Tock(false);
        }
    }
}

class TickingClock
{
    static void Main()
    {
        TickTock tt = new TickTock();
        MyThread mt1 = new MyThread("Tick", tt);
        MyThread mt2 = new MyThread("Tock", tt);

        mt1.Thrd.Join();
        mt2.Thrd.Join();

        Console.WriteLine("clock Stopped");
    }
}
*/