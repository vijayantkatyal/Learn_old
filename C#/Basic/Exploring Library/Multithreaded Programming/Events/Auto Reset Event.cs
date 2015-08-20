/*
using System;
using System.Threading;

class MyThread
{
    public Thread Thrd;
    AutoResetEvent are;

    public MyThread(string name,AutoResetEvent evt)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        are = evt;
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
        are.Set(); // Signal the event
    }
}

class ManualEventDemo
{
    static void Main()
    {
        AutoResetEvent evtObj = new AutoResetEvent(false);

        MyThread mt1 = new MyThread("Event Thread 1", evtObj);
        Console.WriteLine("Main thread waiting for event.");

        // Wait for signaled event.
        evtObj.WaitOne();

        Console.WriteLine("Main thread received first event.");


        mt1 = new MyThread("Event Thread 2", evtObj);

        evtObj.WaitOne();

        Console.WriteLine("Main thread received second event.");
    }
}
*/