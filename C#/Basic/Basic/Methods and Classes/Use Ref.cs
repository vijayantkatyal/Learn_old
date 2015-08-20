/*
// Use ref to pass a value type by reference.

using System;

class RefTest
{
    // This Method changes its arguments. Notice the use of ref.

    public void Sqrt(ref int i)
    {
        i = i * i;
    }
}

class RefDemo
{
    static void Main()
    {
        RefTest ob = new RefTest();

        int a = 10;

        Console.WriteLine("a before call: " + a);

        ob.Sqrt(ref a); // Notice Use of Ref.

        Console.WriteLine("a after call: " + a);
    }
}
*/