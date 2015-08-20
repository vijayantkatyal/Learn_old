/*
// A non-generic class can be the base class of a generic derived class.

using System;

class NonGen
{
    int num;

    public NonGen(int i)
    {
        num = i;
    }

    public int GetNum()
    {
        return num;
    }
}

class Gen<T> : NonGen
{
    T ob;

    public Gen(T o, int i): base(i)
    {
        ob = o;
    }

    public T GetOb()
    {
        return ob;
    }
}

class HierDemo3
{
    static void Main()
    {
        Gen<string> w = new Gen<string>("Hello", 47);

        Console.Write(w.GetOb() + " ");
        Console.WriteLine(w.GetNum());
    }
}
*/