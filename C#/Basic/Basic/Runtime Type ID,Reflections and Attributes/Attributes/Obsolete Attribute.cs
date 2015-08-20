/*
using System;

class Test
{
    [Obsolete("Use MyMeth2, instead.")]
    public static int MyMeth(int a,int b)
    {
        return a / b;
    }

    public static int MyMeth2(int a,int b)
    {
        return b == 0 ? 0 : a / b;
    }

    static void Main()
    {
        // Warning Displayed for this.
        Console.WriteLine("4 / 3 is " + Test.MyMeth(4, 3));

        // No Warning here.
        Console.WriteLine("4 / 3 is " + Test.MyMeth2(4, 3));
    }
}
*/