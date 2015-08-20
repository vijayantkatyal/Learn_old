/*
// An example of operator overloading.

using System;

// A three-dimensional coordinate class.

class ThreeD
{
    int x, y, z; // 3-D Coordinates.

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

    // Overload binary +.
    public static ThreeD operator +(ThreeD op1,ThreeD op2)
    {
        ThreeD result = new ThreeD();

        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;

        return result;
    }

    // Overload binary + for object + int.
    public static ThreeD operator +(ThreeD op1,int op2)
    {
        ThreeD result = new ThreeD();

        result.x = op1.x + op2;
        result.y = op1.y + op2;
        result.z = op1.z + op2;

        return result;
    }

    // Overload binary -.
    public static ThreeD operator -(ThreeD op1,ThreeD op2)
    {
        ThreeD result = new ThreeD();

        result.x = op1.x - op2.x;
        result.y = op1.y - op2.y;
        result.z = op1.z - op2.z;

        return result;
    }

    // Show x, y, z coordinates.
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
        ThreeD c;

        Console.WriteLine("Here is a: ");
        a.Show();
        Console.WriteLine();
        Console.WriteLine("Here is b: ");
        b.Show();
        Console.WriteLine();

        c = a + b; // add a and b together.
        Console.Write("Result of a+b: ");
        c.Show();
        Console.WriteLine();

        c = a + b + c;
        Console.Write("Result of a + b + c: ");
        c.Show();

        c = c - a; // subtract a.
        Console.Write("Result of c-a: ");
        c.Show();
        Console.WriteLine();

        c = c - b;
        Console.Write("Result of c-b: ");
        c.Show();
        Console.WriteLine();

        c = b + 10; // threeD + int.
        Console.Write("Result of b + 10: ");
        c.Show();
    }
}
*/