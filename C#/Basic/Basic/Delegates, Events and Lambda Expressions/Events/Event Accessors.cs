﻿/*
using System;

delegate void MyEventHandler();

class MyEvent
{
    MyEventHandler[] evnt = new MyEventHandler[3];

    public event MyEventHandler SomeEvent
    {
        // add an event to the list.
        add
        {
            int i;

            for (i = 0; i < 3; i++)
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    break;
                }
            if (i == 3) Console.WriteLine("Event list full.");
        }

        // Remove an event from the list.
        remove
        {
            int i;

            for (i = 0; i < 3; i++)
                if (evnt[i] == value)
                {
                    evnt[i] = null;
                    break;
                }
            if (i == 3) Console.WriteLine("Event Handler not found.");
        }
    }

    public void OnSomeEvent()
    {
        for (int i = 0; i < 3; i++)
            if (evnt[i] != null) evnt[i]();
    }
}

class W
{
    public void Whandler()
    {
        Console.WriteLine("Event received by W object");
    }
}

class X
{
    public void Xhandler()
    {
        Console.WriteLine("Event received by X object");
    }
}

class Y
{
    public void Yhandler()
    {
        Console.WriteLine("Event received by Y object");
    }
}

class Z
{
    public void Zhandler()
    {
        Console.WriteLine("Event received by Z object");
    }
}


class EventDemo5
{
    static void Main()
    {
        MyEvent evt = new MyEvent();
        W wOb = new W();
        X xOb = new X();
        Y yOb = new Y();
        Z zOb = new Z();

        // Add handlers to event list.
        Console.WriteLine("Adding events.");
        evt.SomeEvent += wOb.Whandler;
        evt.SomeEvent += xOb.Xhandler;
        evt.SomeEvent += yOb.Yhandler;
        evt.SomeEvent += zOb.Zhandler; // can't store this (full).
        Console.WriteLine();

        // Raise the events.
        evt.OnSomeEvent();
        Console.WriteLine();

        // Remove a handler.
        Console.WriteLine("Remove xOb.Xhandler.");
        evt.SomeEvent -= xOb.Xhandler;
        evt.OnSomeEvent();

        Console.WriteLine();

        // Try to remove it again.
        Console.WriteLine("Try to remove xOb.Xhandler again.");
        evt.SomeEvent -= xOb.Xhandler;
        evt.OnSomeEvent();

        Console.WriteLine();

        // Now, add Zhandler.
        Console.WriteLine("Add, zOb.Zhandler.");
        evt.SomeEvent += zOb.Zhandler;
        evt.OnSomeEvent();
    }
}
*/