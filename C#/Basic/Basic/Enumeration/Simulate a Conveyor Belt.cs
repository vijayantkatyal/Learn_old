/*
// Simulate a Conveyor belt.

using System;

class ConveyorControl
{
    // enumerate the conveyor commands.
    public enum Action { Start, Stop, Forward, Reverse };

    public void Conveyor(Action com)
    {
        switch (com)
        {
            case Action.Start:
                Console.WriteLine("Starting Conveyor.");
                break;
            case Action.Stop:
                Console.WriteLine("Stopping Conveyor.");
                break;
            case Action.Forward:
                Console.WriteLine("Moving Forward.");
                break;
            case Action.Reverse:
                Console.WriteLine("Moving Backward");
                break;
        }
    }
}

class Conveyordemo
{
    static void Main()
    {
        ConveyorControl c = new ConveyorControl();

        c.Conveyor(ConveyorControl.Action.Start);
        c.Conveyor(ConveyorControl.Action.Forward);
        c.Conveyor(ConveyorControl.Action.Reverse);
        c.Conveyor(ConveyorControl.Action.Stop);
    }
}
*/