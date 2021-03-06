﻿/*
// A simple class hierarchy

using System;

class TwoDShape
{
    public double Width;
    public double Height;

    public void ShowDim()
    {
        Console.WriteLine("Width and Height are " + Width + " and " + Height);
    }
}

// Triangle is derived from TwoDShape
class Triangle:TwoDShape
{
    public string Style;

    public double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + Style);
    }
}

class Shapes
{
    static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();

        t1.Width = 4.0;
        t1.Height = 4.0;
        t1.Style = "isosceles";

        t2.Width = 8.0;
        t2.Height = 12.0;
        t2.Style = "right";

        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());
    }
}
*/