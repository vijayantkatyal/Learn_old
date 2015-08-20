/*
using System;
using System.Threading;

class MyThread
{
    public Thread Thrd;

    public MyThread(string name)
    {
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        Console.WriteLine(Thrd.Name + " starting");

        for (int i = 1; i <= 1000; i++)
        {
            try
            {
                Console.Write(i + " ");
                if ((i % 10) == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(250);
                }
            }
            catch (ThreadAbortException exc)
            {
                if ((int)exc.ExceptionState == 0)
                {
                    Console.WriteLine("Abort Cancelled! Code is " + exc.ExceptionState);
                    Thread.ResetAbort();
                }
                else
                {
                    Console.WriteLine("Thread aboting, code is " + exc.ExceptionState);
                }
            }
        }
        Console.WriteLine(Thrd.Name + " exiting normally");
    }
}

class ResetAbort
{
    static void Main()
    {
        MyThread mt1 = new MyThread("My Thread");
        Thread.Sleep(1000);

        Console.WriteLine("Stopping Thread");
        mt1.Thrd.Abort(0);

        Thread.Sleep(1000);

        Console.WriteLine("Stopping Thread");
        mt1.Thrd.Abort(100);

        mt1.Thrd.Join();

        Console.WriteLine("Main thread terminating");
    }
}
*/