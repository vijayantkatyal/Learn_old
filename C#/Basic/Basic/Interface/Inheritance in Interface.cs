/*
// One Interface can inherit another.

using System;

interface IA
{
    void Meth1();
    void Meth2();
}

interface IB:IA
{
    void Meth3();
}

class MyClass:IB
{
    public void Meth1()
    {
        Console.WriteLine("Implement Meth1().");
    }

    public void Meth2()
    {
        Console.WriteLine("Implement Meth2().");
    }

    public void Meth3()
    {
        Console.WriteLine("Implement Meth3().");
    }
}


class IFExtend
{
    static void Main()
    {
        MyClass ob = new MyClass();

        ob.Meth1();
        ob.Meth2();
        ob.Meth3();
    }
}
*/