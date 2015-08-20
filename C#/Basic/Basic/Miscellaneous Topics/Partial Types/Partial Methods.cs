/*
using System;

partial class XY
{
    public int X { get; set; }

    partial void Show()
    {
        Console.WriteLine("{0}, {1}", X, Y);
    }
}

partial class XY
{
    public int Y { get; set; }

    public void ShowXY()
    {
        Show();
    }
}
partial class XY
{
    public XY(int a,int b)
    {
        X = a;
        Y = b;
    }

    partial void Show();
}

class Test
{
    static void Main()
    {
        XY xy = new XY(1, 2);

        xy.ShowXY();
    }
}
*/