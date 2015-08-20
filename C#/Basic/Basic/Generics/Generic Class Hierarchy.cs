/*
using System;

class Gen<T>
{
    T ob;

    public Gen(T o)
    {
        ob = o;
    }

    // Return ob.
    public T GetOb()
    {
        return ob;
    }
}

// A Class Derived from Gen.
class Gen2<T>: Gen<T>
{
    public Gen2(T o):base(o)
    {
        // ...
    }
}

class GenHierDemo
{
    static void Main()
    {
        Gen2<string> g2 = new Gen2<string>("Hello");
 
        Console.WriteLine(g2.GetOb());
    }
}
*/