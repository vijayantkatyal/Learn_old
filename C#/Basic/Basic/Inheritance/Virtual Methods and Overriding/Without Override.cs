/*
using System;

class Base
{
    public virtual void Who()
    {
        Console.WriteLine("Who() in Base");
    }
}

class Derived1:Base
{
    public override void Who()
    {
        Console.WriteLine("Who() in Derived1");
    }
}

class Derived2:Base
{
    public void Who()
    {
        Console.WriteLine("Who() in Derived2");
    }
}

class NoOverrideDemo
{
    static void Main()
    {
        Base baseOb = new Base();
        Derived1 dOb1 = new Derived1();
        Derived2 dOb2 = new Derived2();

        Base baseRef;

        baseRef = baseOb;
        baseRef.Who();

        baseRef = dOb1;
        baseRef.Who();

        baseRef = dOb2;
        baseRef.Who();
    }
}
*/