/*
// A multilevel hierarchy

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

    public Triangle(double x):base(x)
    {
        style = "isosceles";
    }

    public double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + style);
    }
}

class ColorTriangle:Triangle
{
    string color;

    public ColorTriangle(string c,string s,double w,double h):base(s,w,h)
    {
        color = c;
    }

    public void ShowColor()
    {
        Console.WriteLine("Color is " + color);
    }
}

class Shapes6
{
    static void Main()
    {
        ColorTriangle t1 = new ColorTriangle("Blue", "right", 8.0, 12.0);
        ColorTriangle t2 = new ColorTriangle("Red", "isosceles", 2.0, 2.0);

        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        t1.ShowColor();
        Console.WriteLine("Area is " + t1.Area());
        Console.WriteLine();
        
        Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        t2.ShowColor();
        Console.WriteLine("Area is " + t2.Area());
        Console.WriteLine();

    }
}
*/