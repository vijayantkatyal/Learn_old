/*
using System;

class Gen<T,V>
{
    T ob1;
    V ob2;

    public void Set(T o)
    {
        ob1 = o;
    }

    public void Set(V o)
    {
        ob2 = o;
    }
}

class AmbiguityDemo
{
    static void Main()
    {
        Gen<int, double> Ok = new Gen<int, double>();

        Gen<int, int> notOk = new Gen<int, int>();

        Ok.Set(10);

        notOk.Set(10); // ambiguos , type args are the same.
    }
}
*/