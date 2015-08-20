/*
using System;
using System.Threading;

class MyThread
{
    public int Count;
    public Thread Thrd;

    public MyThread(string name,int num)
    {
        Count = 0;
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start(num);
    }

    void Run(object num)
    {
        Console.WriteLine(Thrd.Name + " Starting with count of " + num);

        do
        {
            Thread.Sleep(500);
            Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);
            Count++;
        }
        while (Count < (int) num);

        Console.WriteLine(Thrd.Name + " terminatng");
    }
}

class PassArgDemo
{
    static void Main()
    {
        MyThread mt = new MyThread("Child #1", 5);
        MyThread mt2 = new MyThread("Child #2", 3);

        do
        {
            Thread.Sleep(100);
        }
        while (mt.Thrd.IsAlive | mt2.Thrd.IsAlive);

        Console.WriteLine("Main thread ending.");
    }
}
*/