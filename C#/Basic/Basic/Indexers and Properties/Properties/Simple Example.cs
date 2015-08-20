/*
using System;

class SimpProp
{
    int prop; // field managed by MyProp

    //public SimpProp()
    //{
    //    prop = 0;
    //}

    // this is the property that supports access to private instance variable prop.
    //it allows only positive values.

    public int MyProp
    {
        get
        {
            return prop;
        }
        set
        {
            if (value >= 0) prop = value;
        }
    }
}

// Demonstrate a property.

class PropertyDemo
{
    static void Main()
    {
        SimpProp ob = new SimpProp();

        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);
        ob.MyProp = 100; // Assign Value.
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);

        // Can't Assign negative value to prop.
        Console.WriteLine("Attempting to assign -10 to ob.MyProp");
        ob.MyProp = -10;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);
    }
}
*/