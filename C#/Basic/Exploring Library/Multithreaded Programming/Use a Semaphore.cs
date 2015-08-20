/*
using System;
using System.Threading;

class MyThread
{
    public Thread Thrd;

    static Semaphore sem = new Semaphore(2, 2);

    public MyThread(string name)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        Console.WriteLine(Thrd.Name + " is waiting for a permit.");
        sem.WaitOne();

        Console.WriteLine(Thrd.Name + " acquires a permit.");

        for (char ch = 'A'; ch < 'D'; ch++)
        {
            Console.WriteLine(Thrd.Name + " : " + ch + " ");
            Thread.Sleep(500);
        }

        Console.WriteLine(Thrd.Name + " releases a permit.");

        sem.Release();
    }
}

class SemaphoreDemo
{
    static void Main()
    {
        MyThread mt1 = new MyThread("Thread #1");
        MyThread mt2 = new MyThread("Thread #2");
        MyThread mt3 = new MyThread("Thread #3");

        mt1.Thrd.Join();
        mt2.Thrd.Join();
        mt3.Thrd.Join();
    }
}
*/