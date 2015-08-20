/*
// A base class reference can refer to a derived class object.

using System;

class X
{
    public int a;

    public X(int i)
    {
        a = i;
    }
}

class Y : X
{
    public int b;

    public Y(int i,int j):base(j)
    {
        b = i;
    }
}

class BaseRef
{
    static void Main()
    {
        X x = new X(10);
        X x2;
        Y y = new Y(5, 6);

        x2 = x;
        Console.WriteLine("x2.a: " + x2.a);

        x2 = y;
        Console.WriteLine("x2.a: " + x2.a);

        x2.a = 19;
        //x2.b = 27; // doesn't have b member.
    }
}
*/