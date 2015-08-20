/*
// Use an access modifier with an accessor.

using System;

class PropAccess
{
    int prop;

    public PropAccess()
    {
        prop = 0;
    }

    public int MyProp
    {
        get
        {
            return prop;
        }
        private set
        {
            prop = value;
        }
    }

    public void IncrProp()
    {
        MyProp++;
    }
}

class PropAccessDemo
{
    static void Main()
    {
        PropAccess ob = new PropAccess();

        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

        //ob.MyProp = 100; // can't access it.

        ob.IncrProp();

        Console.WriteLine("Value of ob.MyProp after increment: " + ob.MyProp);
    }
}
*/