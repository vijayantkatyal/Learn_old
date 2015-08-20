/*
// demonstrate protected

using System;

class B
{
    protected int i, j;

    public void Set(int a,int b)
    {
        i = a;
        j = b;
    }

    public void Show()
    {
        Console.WriteLine(i + " " + j);
    }
}

class D:B
{
    int k;

    public void Setk()
    {
        k = i * j;
    }

    public void Showk()
    {
        Console.WriteLine(k);
    }
}

class ProtectedDemo
{
    static void Main()
    {
        D ob = new D();

        ob.Set(2, 3);
        ob.Show();

        ob.Setk();
        ob.Showk();
    }
}
*/