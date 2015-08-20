/*
using System;
using System.Threading;

class MyThread
{
    public Thread Thrd;

    public MyThread (string name)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        Console.WriteLine(Thrd.Name + " starting.");

        for (int i = 1; i <= 1000; i++)
        {
            Console.Write(i + " ");
            if ((i % 10) == 0)
            {
                Console.WriteLine();
                Thread.Sleep(250);
            }
        }
        Console.WriteLine(Thrd.Name + " exiting.");
    }
}

class StopDemo
{
    static void Main()
    {
        MyThread mt1 = new MyThread("My thread");

        Thread.Sleep(2000);

        Console.WriteLine("Stopping thread");
        mt1.Thrd.Abort();

        mt1.Thrd.Join();
        Console.WriteLine("Main thread terminating");
    }
}
*/