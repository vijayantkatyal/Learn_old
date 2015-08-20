/*
// Using base to overcome name hiding.

using System;

class A
{
    public int i = 0;
}

class B : A
{
    new int i;

    public B(int a,int b)
    {
        base.i = a; // i in A
        i = b; // i in B
    }

    public void Show()
    {
        Console.WriteLine("i in base class: " + base.i);
        Console.WriteLine("i in derived class: " + i);
    }
}

class NameHiding
{
    static void Main()
    {
        B ob = new B(1,2);

        ob.Show();
    }
}
*/