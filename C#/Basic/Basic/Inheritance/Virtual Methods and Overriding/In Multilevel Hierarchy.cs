/*
using System;

class Base
{
    public virtual void Who()
    {
        Console.WriteLine("Who() in base");
    }
}

class Derived1:Base
{
    public override void Who()
    {
        Console.WriteLine("Who() in Derived1");
    }
}

class Derived2:Derived1
{

}

class Derived3:Derived2
{

}

class NoOverrideDemo2
{
    static void Main()
    {
        Derived3 dOb3 = new Derived3();
        Base baseref;

        baseref = dOb3;
        baseref.Who();
    }
}
*/