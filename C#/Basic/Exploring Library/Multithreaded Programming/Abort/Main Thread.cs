/*
using System;
using System.Threading;

class UseMain
{
    static void Main()
    {
        Thread Thrd;

        Thrd=Thread.CurrentThread;

        if(Thrd.Name == null)
        {
            Console.WriteLine("Main thread has no name");
        }
        else
        {
            Console.WriteLine("Main thread is called: "+Thrd.Name);
        }

        Console.WriteLine("Priority: " + Thrd.Priority);

        Console.WriteLine();

        Console.WriteLine("Setting name and Priority.\n");
        Thrd.Name = "Main Thread";
        Thrd.Priority = ThreadPriority.AboveNormal;
        Console.WriteLine("Name: {0}\nPriority:{1}", Thrd.Name, Thrd.Priority);

        //Thrd.Join();
    }
}
*/