/*
using System;

public interface IMyCoVarGenIF<out T>
{
    T GetObject();
}

class MyClass<T>:IMyCoVarGenIF<T>
{
    T obj;

    public MyClass(T v)
    {
        obj = v;
    }

    public T GetObject()
    {
        return obj;
    }
}

class Alpha
{
    string name;

    public Alpha (string n)
    {
        name=n;
    }

    public String Getname()
    {
        return name;
    }
}

class Beta:Alpha
{
    public Beta(string n):base(n)
    {
    
    }
}

class VarianceDemo
{
    static void Main()
    {
        IMyCoVarGenIF<Alpha> AlphaRef=new MyClass<Alpha>(new Alpha("Alpha #1"));

        Console.WriteLine("Name of Object referre to by AlphaRef is "+AlphaRef.GetObject().Getname());

        AlphaRef=new MyClass<Beta>(new Beta("Beta #1"));

        Console.WriteLine("Name of object referred to by AlphaRef is now "+AlphaRef.GetObject().Getname());
    }
}
*/