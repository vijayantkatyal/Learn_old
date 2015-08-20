﻿/*
// Explicitly implement an interface member.

using System;

interface IEven
{
    bool IsOdd(int x);
    bool IsEven(int x);
}

class MyClass:IEven
{
    // Explicit implementation.this member is private by default.

    bool IEven.IsOdd(int x)
    {
        if ((x % 2) != 0) return true;
        else return false;
    }

    // Normal Implementation.
    public bool IsEven(int x)
    {
        IEven o = this; // interface reference to the invoking object.

        return !o.IsOdd(x);
    }
}

class Demo
{
    static void Main()
    {
        MyClass ob = new MyClass();
        bool result;

        result = ob.IsEven(4);
        if (result) Console.WriteLine("4 is even.");

        //result = ob.IsOdd(4); // Error , IsOdd is private now.

        IEven iRef = (IEven) ob;
        result = iRef.IsOdd(3);
        if (result) Console.WriteLine("3 is Odd.");
    }
}
*/