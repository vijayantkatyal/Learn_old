/*
// illustrate explicit conversion operator.

using System;

// a 3-D coordinate class.
class ThreeD
{
    int x, y, z;

    public ThreeD()
    {
        x = y = z = 0;
    }

    public ThreeD(int i,int j,int k)
    {
        x = i;
        y = j;
        z = k;
    }

    // overload binary +.
    public static ThreeD operator +(ThreeD op1,ThreeD op2)
    {
        ThreeD result = new ThreeD();

        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;

        return result;
    }

    // An implicit conversion from ThreeD to int.
    public static explicit operator int(ThreeD op1)
    {
        return op1.x * op1.y * op1.z;
    }

    public void Show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}

class ThreeDDemo
{
    static void Main()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD();
        int i;

        Console.Write("Here is a: ");
        a.Show();
        Console.WriteLine();
        Console.Write("Here is b: ");
        b.Show();
        Console.WriteLine();

        c = a + b;
        Console.Write("Result of a+b: ");
        c.Show();

        Console.WriteLine();

        i = (int) a; // convert to int.
        Console.WriteLine("Result of i = a: " + i);
        Console.WriteLine();

        i = (int) a * 2 - (int) b; // convert to int.
        Console.WriteLine("Result of a * 2 - b: " + i);
    }
}
*/