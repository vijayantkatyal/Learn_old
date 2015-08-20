/*
// An Example of inheritance-related name hiding.

using System;

class A
{
    public int i = 0;
}

class B : A
{
    new int i;

    public B(int b)
    {
        i = b;
    }

    public void Show()
    {
        Console.WriteLine("i in derived class: " + i);
    }
}

class NameHiding
{
    static void Main()
    {
        B ob = new B(2);

        ob.Show();
    }
}
*/