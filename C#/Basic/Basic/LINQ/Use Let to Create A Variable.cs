/*
using System;
using System.Linq;

class LetDemo
{
    static void Main()
    {
        string[] strs = { "alpha", "beta", "gamma" };

        var chrs = from str in strs
                   let chrArray = str.ToCharArray()
                   from ch in chrArray
                   orderby ch
                   select ch;

        Console.WriteLine("The individual characters in sorted order:");

        foreach (char c in chrs) Console.Write(c + " ");

        Console.WriteLine();
    }
}
*/