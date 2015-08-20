/*
// Add more constructors to TwoDShape.

using System;

class TwoDShape
{
    double pri_width;
    double pri_height;

    public double Width
    {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }

    public double Height
    {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }

    public TwoDShape()
    {
        Width = Height = 0.0;
    }

    public TwoDShape(double w,double h)
    {
        Width = w;
        Height = h;
    }

    public TwoDShape(double x)
    {
        Width = Height = x;
    }

    public void ShowDim()
    {
        Console.WriteLine("Width and Height are " + Width + " and " + Height);
    }
}

class Triangle:TwoDShape
{
    string style;

    public Triangle()
    {
        style = "null";
    }

    public Triangle(string s,double w,double h):base(w,h)
    {
        style = s;
    }

    public Triangle (double x):base(x)
    {
        style = "isosceles";
    }

    public double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine("Trinagle is " + style);
    }
}

class Shapes5
{
    static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle("right", 8.0, 12.0);
        Triangle t3 = new Triangle(4.0);

        t1 = t2;

        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());

        Console.WriteLine();

        Console.WriteLine("Info for t3: ");
        t3.ShowStyle();
        t3.ShowDim();
        Console.WriteLine("Area is " + t3.Area());
    }
}
*/