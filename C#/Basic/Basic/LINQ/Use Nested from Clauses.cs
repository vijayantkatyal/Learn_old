/*
using System;
using System.Linq;

class ChrPair
{
    public char First;
    public char Second;

    public ChrPair(char c,char c2)
    {
        First = c;
        Second = c2;
    }
}

class MultipleForms
{
    static void Main()
    {
        char[] chrs = { 'A', 'B', 'C' };
        char[] chrs2 = { 'X', 'Y', 'Z' };

        var pairs = from ch1 in chrs
                    from ch2 in chrs2
                    select new ChrPair(ch1, ch2);

        Console.WriteLine("All Combinations of ABC with XYZ");

        foreach (var p in pairs)
            Console.WriteLine("{0} {1}", p.First, p.Second);
    }
}
*/