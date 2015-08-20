/*
// Create an Abstract Class.

using System;

abstract class TwoDShape
{
    double pri_width;
    double pri_height;

    public string name { get; set; }

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
        name = "null";
    }
    
    public TwoDShape(double w,double h,string n)
    {
        Width = w;
        Height = h;
        name = n;
    }

    public TwoDShape(double x,string n)
    {
        Width = Height = x;
        name = n;
    }

    public TwoDShape(TwoDShape ob)
    {
        Width = ob.Width;
        Height = ob.Height;
        name = ob.name;
    }

    public void ShowDim()
    {
        Console.WriteLine("Width and Height are " + Width + " and " + Height);
    }

    public abstract double Area();
}

class Triangle:TwoDShape
{
    string style;

    public Triangle()
    {
        style = "null";
    }

    public Triangle(string s,double w,double h):base(w,h,"triangle")
    {
        style = s;
    }

    public Triangle(double x):base(x,"triangle")
    {
        style = "isosceles";
    }

    public Triangle (Triangle ob):base(ob)
    {
        style = ob.style;
    }

    public override double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + style);
    }
}

class Rectangle:TwoDShape
{
    public Rectangle(double w,double h):base(w,h,"rectangle")
    {

    }

    public Rectangle(double x):base(x,"rectangle")
    {

    }

    public Rectangle (Rectangle ob):base(ob)
    {

    }

    public bool IsSquare()
    {
        if (Width == Height) return true;
        return false;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

class AbsShape
{
    static void Main()
    {
        TwoDShape[] shapes = new TwoDShape[4];

        shapes[0] = new Triangle("right", 8.0, 12.0);
        shapes[1] = new Rectangle(10);
        shapes[2] = new Rectangle(10, 4);
        shapes[3] = new Triangle(7.0);

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine("object is " + shapes[i].name);
            Console.WriteLine("Area is " + shapes[i].Area());
            Console.WriteLine();
        }
    }
}
*/