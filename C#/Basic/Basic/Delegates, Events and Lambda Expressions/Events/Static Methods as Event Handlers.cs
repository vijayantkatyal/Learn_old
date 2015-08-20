/*
using System;

delegate void MyEventHandler();

class MyEvent
{
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent();
    }
}

class X
{
    public static void Xhandler()
    {
        Console.WriteLine("Event received by class.");
    }
}

class EventDemo4
{
    static void Main()
    {
        MyEvent evt = new MyEvent();

        evt.SomeEvent += X.Xhandler;

        // Raise the event.
        evt.OnSomeEvent();
    }
}
*/