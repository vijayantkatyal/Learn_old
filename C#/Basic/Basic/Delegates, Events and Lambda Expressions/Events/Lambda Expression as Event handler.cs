/*
using System;

delegate void MyeventHandler(int n);

class MyEvent
{
    public event MyeventHandler SomeEvent;

    public void OnSomeEvent(int n)
    {
        if (SomeEvent != null)
            SomeEvent(n);
    }
}

class LambdaEventDemo
{
    static void Main()
    {
        MyEvent evt = new MyEvent();

        // use a lambda expression as an event handler.

        evt.SomeEvent += (n) =>
            Console.WriteLine("Event received. Value is " + n);

        // Raise the event twice.
        evt.OnSomeEvent(1);
        evt.OnSomeEvent(2);
    }
}
*/