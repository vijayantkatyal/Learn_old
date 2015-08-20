/*
using System;
using System.Threading;
using System.Threading.Tasks;

class MyClass
{
    public void MyTask()
    {
        Console.WriteLine("MyTask starting");

        for (int count = 0; count < 10; count++)
        {
            Thread.Sleep(500);
            Console.WriteLine("In MyTask(), count is " + count);
        }

        Console.WriteLine("MyTask terminating");
    }
}

class DemoTask
{
    static void Main()
    {
        Console.WriteLine("Main thread starting");

        // Construct a MyClass Object.
        MyClass mc = new MyClass();

        // Construct a task on mc.MyTask().
        Task tsk = new Task(mc.MyTask);

        // Run the Task
        tsk.Start();

        // Keep Main() alive until MyTask() finishes.
        for (int i = 0; i < 60; i++)
        {
            Console.Write(".");
            Thread.Sleep(100);
        }

        Console.WriteLine("Main thread ending.");
    }
}
*/