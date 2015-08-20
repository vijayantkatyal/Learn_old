/*
// Use lock to synchronize access to an object.

using System;
using System.Threading;

class SumArray
{
    int sum;
    object lockon = new object(); // a private object to lock on

    public int SumIt(int[] nums)
    {
        lock (lockon)
        {
            sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.WriteLine("Running total for "+ Thread.CurrentThread.Name +" is " + sum);
                Thread.Sleep(10);
            }
            return sum;
        }
    }
}

class MyThread
{
    public Thread Thrd;
    int[] a;
    int answer;

    static SumArray sa = new SumArray();

    public MyThread(string name,int[] nums)
    {
        a = nums;
        Thrd = new Thread(this.Run);
        Thrd.Name = name;
        Thrd.Start();
    }

    void Run()
    {
        Console.WriteLine(Thrd.Name + " starting");
        answer = sa.SumIt(a);

        Console.WriteLine("Sum for " + Thrd.Name + " is " + answer);
        Console.WriteLine(Thrd.Name + " terminating");
    }
}

class Sync
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };

        MyThread mt1 = new MyThread("Child #1", a);
        MyThread mt2 = new MyThread("Child #2", a);

        mt1.Thrd.Join();
        mt2.Thrd.Join();
    }
}
*/