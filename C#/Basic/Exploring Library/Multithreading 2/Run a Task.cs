/*
using System;
using System.Threading;
using System.Threading.Tasks;

class DemoTask
{
    static void MyTask()
    {
        Console.WriteLine("MyTask() starting");

        for (int count = 0; count < 10; count++)
        {
            Thread.Sleep(500);
            Console.WriteLine("In MyTask(), count is " + count);
        }

        Console.WriteLine("MyTask terminating");
    }

    static void Main()
    {
        Console.WriteLine("Main thread starting");

        // construct a task
        Task tsk = new Task(MyTask);

        // Run a task
        tsk.Start();

        // keep main alive until MyTask() finishes
        for (int i = 0; i < 60; i++)
        {
            Console.Write(".");
            Thread.Sleep(100);
        }

        Console.WriteLine("Main thread ending");
    }
}
*/