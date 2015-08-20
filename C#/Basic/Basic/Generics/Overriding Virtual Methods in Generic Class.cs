/*
using System;

class Gen<T>
{
    protected T ob;

    public Gen(T o)
    {
        ob = o;
    }

    public virtual T GetOb()
    {
        Console.Write("Gen's GetOb(): ");
        return ob;
    }
}

class Gen2<T> : Gen<T>
{
    public Gen2(T o)
        : base(o)
    {

    }

    public override T GetOb()
    {
        Console.Write("Gen2's GetOb(): ");
        return ob;
    }
}

class OverrideDemo
{
    static void Main()
    {
        Gen<int> iOb = new Gen<int>(88);

        Console.WriteLine(iOb.GetOb());

        iOb = new Gen2<int>(99);

        Console.WriteLine(iOb.GetOb());
    }
}
*/