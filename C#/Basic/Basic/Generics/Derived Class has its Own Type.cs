/*
using System;

class Gen<T>
{
    T ob;
    
    public Gen(T o)
    {
        ob = o;
    }

    public T GetOb()
    {
        return ob;
    }
}

class Gen2<T,V>:Gen<T>
{
    V ob2;

    public Gen2(T o,V o2):base(o)
    {
        ob2 = o2;
    }

    public V GetObj2()
    {
        return ob2;
    }
}

class GetHierDemo2
{
    static void Main()
    {
        Gen2<string, int> x = new Gen2<string, int>("Value is: ", 99);

        Console.Write(x.GetOb());
        Console.WriteLine(x.GetObj2());
    }
}
*/