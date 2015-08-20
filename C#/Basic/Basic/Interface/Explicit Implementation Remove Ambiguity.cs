/*
using System;

interface IMyIF_A
{
    int Meth(int x);
}

interface IMyIF_B
{
    int Meth(int x);
}

class MyClass:IMyIF_A,IMyIF_B
{
    int IMyIF_A.Meth(int x)
    {
        return x + x;
    }

    int IMyIF_B.Meth(int x)
    {
        return x * x;
    }

    public int MethA(int x)
    {
        IMyIF_A a_ob;
        a_ob = this;
        return a_ob.Meth(x);
    }

    public int MethB(int x)
    {
        IMyIF_B b_ob;
        b_ob = this;
        return b_ob.Meth(x);
    }
}

class FQIFNames
{
    static void Main()
    {
        MyClass ob = new MyClass();

        Console.Write("Calling IMyIF_A.Meth(): ");
        Console.WriteLine(ob.MethA(3));

        Console.Write("Calling IMyIF_B.Meth(): ");
        Console.WriteLine(ob.MethB(3));
    }
}
*/