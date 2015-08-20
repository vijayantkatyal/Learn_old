/*
using System;

public interface IMyContraVarGenIF<in T>
{
    void Show(T obj);
}

class MyClass<T>:IMyContraVarGenIF<T>
{
    public void Show(T x)
    {
        Console.WriteLine(x);
    }
}

class Alpha
{
    public override string ToString()
    {
        return "This is Alpha object.";
    }
}

class Beta:Alpha
{
    public override string ToString()
    {
        return "This is Beta object.";
    }
}

class VarianceDemo
{
    static void Main()
    {
        IMyContraVarGenIF<Alpha> AlphaRef = new MyClass<Alpha>();

        IMyContraVarGenIF<Beta> BetaRef=new MyClass<Beta>();

        IMyContraVarGenIF<Beta> BetaRef2 = new MyClass<Alpha>();

        BetaRef.Show(new Beta());

        BetaRef = AlphaRef;
        BetaRef.Show(new Beta());
    }
}
*/