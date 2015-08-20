/*
using System;

class MyClass:IComparable<MyClass>,IEquatable<MyClass>
{
    public int Val;

    public MyClass(int x)
    {
        Val = x;
    }

    // Implement IComparable<T>.
    public int CompareTo(MyClass other)
    {
        return Val - other.Val;
    }

    // Implement IEquatable<T>.
    public bool Equals(MyClass other)
    {
        return Val == other.Val;
    }

    // An Override of Equals(Object).
    public override bool Equals(object obj)
    {
        if (obj is MyClass)
            return Equals((MyClass) obj);
        return false;
    }

    // An Override of GetHashCode().
    public override int GetHashCode()
    {
        return Val.GetHashCode();
    }
    
}


class CompareDemo
{
    // Require IEquatable<T> interface.
    public static bool IsIn<T>(T what, T[] obs) where T : IEquatable<T>
    {
        foreach (T v in obs)
        {
            if (v.Equals(what))
                return true;
        }
        return false;
    }

    public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
    {
        if (what.CompareTo(obs[0]) < 0 || what.CompareTo(obs[obs.Length - 1]) > 0) return false;
        return true;
    }

    // Demonstrate comparisons.
    static void Main()
    {
        // Use IsIn() with int.
        int[] nums = { 1, 2, 3, 4, 5 };

        if (IsIn(2, nums))
            Console.WriteLine("2 is found");

        if (IsIn(99, nums))
            Console.WriteLine("This won't display.");

        // Use IsIn() with MyClass.
        MyClass[] mcs ={new MyClass(1),new MyClass(2),
                      new MyClass(3),new MyClass(4)};

        if (IsIn(new MyClass(3), mcs))
            Console.WriteLine("MyClass(3) is found");

        if (IsIn(new MyClass(99), mcs))
            Console.WriteLine("This won't display.");

        // Use InRange() with int.
        if (InRange(2, nums))
            Console.WriteLine("2 is within the range of nums.");
        if (!InRange(6, nums))
            Console.WriteLine("6 is NOT within the range of nums.");

        // Use InRange() with MyClass.
        if (InRange(new MyClass(2), mcs))
            Console.WriteLine("MyClass(2) is within the range of mcs.");
        if (!InRange(new MyClass(5), mcs))
            Console.WriteLine("MyClass(5) is NOT within the range of mcs.");
    }
}
*/