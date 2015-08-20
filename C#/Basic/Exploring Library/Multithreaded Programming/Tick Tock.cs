/*
using System;
using System.Threading;

class TickTock
{
    object lockon = new object();

    public void Tick(bool running)
    {
        lock (lockon)
        {
            if (!running)
            {
                Monitor.Pulse(lockon); // Notify any waiting threads.
                return;
            }

            Console.Write("Tick");
            Monitor.Pulse(lockon); // let tock() Run

            Monitor.Wait(lockon); // wait for Tock() to complete
        }
    }

    public void tock(bool running)
    {
        lock (lockon)
        {
            if (!running)
            {
                Monitor.Pulse(lockon);
                return;
            }

            Console.WriteLine("Tock");
            Monitor.Pulse(lockon);

            Monitor.Wait(lockon);
        }
    }
}

class MyThread
{
    public Thread thrd;
    TickTock ttob;

    public MyThread(string name,TickTock tt)
    {
        thrd = new Thread(this.Run);
        ttob = tt;
        thrd.Name = name;
        thrd.Start();
    }

    void Run()
    {
        if (thrd.Name == "Tick")
        {
            for (int i = 0; i < 5; i++) ttob.Tick(true);
            ttob.Tick(false);
        }
        else
        {
            for (int i = 0; i < 5; i++) ttob.tock(true);
            ttob.tock(false);
        }
    }
}

class Tickingclock
{
    static void Main()
    {
        TickTock tt = new TickTock();
        MyThread mt1 = new MyThread("Tick",tt);
        MyThread mt2 = new MyThread("Tock", tt);

        mt1.thrd.Join();
        mt2.thrd.Join();
        Console.WriteLine("Clock Stopped");
    }
}
*/