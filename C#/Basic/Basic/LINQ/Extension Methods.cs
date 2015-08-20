/*
using System;
using System.Globalization;

static class MyExtMeths
{
    public static double Reciprocal(this double v)
    {
        return 1.0 / v;
    }

    public static string RevCase(this string str)
    {
        string temp = "";

        foreach (char ch in str)
        {
            if (char.IsLower(ch)) temp += char.ToUpper(ch, CultureInfo.CurrentCulture);
            else temp += char.ToLower(ch, CultureInfo.CurrentCulture);
        }
        return temp;
    }

    public static double AbsDivideBy(this double n,double d)
    {
        return Math.Abs(n / d);
    }
}

class ExtDemo
{
    static void Main()
    {
        double val = 8.0;
        string str = "Alpha Beta Gamma";

        Console.WriteLine("Reciprocal of {0} is {1}", val, val.Reciprocal());

        Console.WriteLine(str + " after reversing case is " + str.RevCase());

        Console.WriteLine("Result of val.AbsDivideBy(-2): " + val.AbsDivideBy(-2));
    }
}
*/