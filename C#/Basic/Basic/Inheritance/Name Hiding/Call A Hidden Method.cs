/*
// Call a hidden Method

using System;

class A
{
    public int i = 0;

    public void Show()
    {
        Console.WriteLine("i in base class: " + i);
    }
}

class B:A
{
    new int i;

    public B(int a,int b)
    {
        base.i = a;
        i = b;
    }

    new public void Show()
    {
        base.Show();

        Console.WriteLine("i in derived class: " + i);
    }
}

class UncoverName
{
    static void Main()
    {
        B ob = new B(1, 2);

        ob.Show();
    }
}
*/