/*
using System;

class ExplicitConversion
{
    static void Main()
    {
        double x, y;
        byte b;
        int i;
        char ch;
        uint u;
        short s;
        long l;

        x = 10.0;
        y = 3.0;

        //Cast Double to int , Fractional Component lost.
        i = (int) (x / y);
        Console.WriteLine("Integer Outcome of x/y :" + i);
        Console.WriteLine();

        //Cast int to byte , no data lost.
        i = 255;
        b = (byte) i;
        Console.WriteLine("b after assigning 255: {0}", b);

        //Cast int to byte , data lost.
        i = 257;
        b = (byte)i;
        Console.WriteLine("b after assigning 257: " + b);

        //Cast uint to short , no data lost.
        u = 32000;
        s = (short) u;
        Console.WriteLine("s after assigning 32000: " + s);

        //Cast uint to short , data lost.
        u = 64000;
        s = (short)u;
        Console.WriteLine("s after assigning 64000: " + s);

        //Cast long into uint , no data lost.
        l = 64000;
        u = (uint) l;
        Console.WriteLine("u after assigning 64000: " + u);

        //Cast long into uint , data lost.
        l = -12;
        u = (uint) l;
        Console.WriteLine("u after assigning -12: " + u);

        //Cast int into char.
        b = 88;
        ch = (char) b;
        Console.WriteLine("ch after assigning 88: " + ch);

        //Promotion Surprise.
        b = 10;
        b = (byte) (b * b);
        Console.WriteLine("b after assigning 10: " + b);

    }
}
*/