/*
// Demonstrate covariance and contravariance with generic delegate.

using System;

delegate bool SomeOp<in T>(T obj);

delegate T Anotherop<out T,V>(V obj);

class Alpha
{
    public int Val { get; set; }
    public Alpha(int v)
    {
        Val = v;
    }
}

class Beta : Alpha
{
    public Beta(int v):base(v)
    {

    }
}

class GenDelegateVarianceDemo
{
    static bool IsEven(Alpha obj)
    {
        if ((obj.Val % 2) == 0) return true;
        return false;
    }

    static Beta ChangeIt(Alpha obj)
    {
        return new Beta(obj.Val + 2);
    }

    static void Main()
    {
        Alpha objA = new Alpha(4);
        Beta objB = new Beta(9);

        SomeOp<Alpha> checkIt = IsEven;

        SomeOp<Beta> checkIt2;

        checkIt2 = checkIt;

        Console.WriteLine(checkIt2(objB));

        Anotherop<Beta, Alpha> modifyIt = ChangeIt;

        Anotherop<Alpha, Alpha> modifyIt2;

        modifyIt2 = modifyIt;

        objA = modifyIt2(objA);
        Console.WriteLine(objA.Val);
    }
}
*/