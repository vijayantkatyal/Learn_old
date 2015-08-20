/*
// Demonstrate when constructors are called.

using System;

class A
{
    public A()
    {
        Console.WriteLine("Constructing A.");
    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("Constructing B.");
    }
}

class C : B
{
    public C()
    {
        Console.WriteLine("Constructing C.");
    }
}

class OrderOfConstruction
{
    static void Main()
    {
        C c = new C();
    }
}
*/