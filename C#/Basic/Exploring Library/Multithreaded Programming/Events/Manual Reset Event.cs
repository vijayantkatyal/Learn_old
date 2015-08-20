/*
using System;
using System.Threading;

class MyThread
{
    public Thread Thrd;
    ManualResetEvent mre;

    public MyThread(string name,ManualResetEvent evt)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        mre = evt;
        Thrd.Start();
    }

    void Run()
    {
        Console.WriteLine("Inside thread " + Thrd.Name);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Thrd.Name);
            Thread.Sleep(500);
        }
        Console.WriteLine(Thrd.Name + " Done!");
        mre.Set(); // Signal the event
    }
}

class ManualEventDemo
{
    static void Main()
    {
        ManualResetEvent evtObj = new ManualResetEvent(false);

        MyThread mt1 = new MyThread("Event Thread 1", evtObj);
        Console.WriteLine("Main thread waiting for event.");

        // Wait for signaled event.
        evtObj.WaitOne();

        Console.WriteLine("Main thread received first event.");

        evtObj.Reset();

        mt1 = new MyThread("Event Thread 2", evtObj);

        evtObj.WaitOne();

        Console.WriteLine("Main thread received second event.");
    }
}
*/