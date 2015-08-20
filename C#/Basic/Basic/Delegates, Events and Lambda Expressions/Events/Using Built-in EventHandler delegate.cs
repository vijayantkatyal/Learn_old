/*
using System;

class MyEvent
{
    public event EventHandler SomeEvent; // uses EventHandler delegate

    // This is called to raise SomeEvent.
    public void OnSomeEvent()
    {
        if (SomeEvent != null)
        {
            SomeEvent(this, EventArgs.Empty);
        }
    }
}

class EventDemo7
{
    static void Handler(object sender,EventArgs e)
    {
        Console.WriteLine("Event occured.");
        Console.WriteLine("Source is " + sender);
    }

    static void Main()
    {
        MyEvent evt = new MyEvent();

        // Add handler() to event list.
        evt.SomeEvent += Handler;

        // Raise Event.
        evt.OnSomeEvent();
    }
}
*/