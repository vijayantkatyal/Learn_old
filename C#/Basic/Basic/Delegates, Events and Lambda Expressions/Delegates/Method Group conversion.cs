﻿/*
using System;

delegate string StrMod(string str);

class DelegateTest
{
    // Replace spaces with hyphens.
    static string ReplaceSpaces(string s)
    {
        Console.WriteLine("Replacing spaces with hyphens.");
        return s.Replace(' ', '-');
    }

    // Remove spaces.
    static string RemoveSpaces(string s)
    {
        string temp = "";
        int i;

        Console.WriteLine("Removing spaces.");
        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ') temp += s[i];

        return temp;
    }

    // Reverse a string.
    static string Reverse(string s)
    {
        string temp = "";
        int i, j;

        Console.WriteLine("Reverseing string");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j--)
            temp += s[i];
        return temp;
    }

    static void Main()
    {
        // Construct delegate using method group conversion.
        StrMod strOp = ReplaceSpaces;
        string str;

        // Call method through delegate.
        str = strOp("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = RemoveSpaces;
        str = strOp("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = Reverse;
        str = strOp("This is a test.");
        Console.WriteLine("Resulting string: " + str);
    }
}
*/