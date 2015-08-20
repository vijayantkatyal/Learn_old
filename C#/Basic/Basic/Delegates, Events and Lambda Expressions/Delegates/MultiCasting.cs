﻿/*
using System;

delegate void StrMod(ref string str);

class MultiCastDemo
{
    // Replace spaes with hyphens.
    static void ReplaceSpaces(ref string s)
    {
        Console.WriteLine("Replacing spaces with hyphens.");
        s = s.Replace(' ', '-');
    }

    // Remove spaces.
    static void RemoveSpaces(ref string s)
    {
        string temp = "";
        int i;

        Console.WriteLine("Removing spaces.");
        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ') temp += s[i];
        s = temp;
    }

    // Reverse a string.
    static void Reverse(ref string s)
    {
        string temp = "";
        int i, j;

        Console.WriteLine("Reversing string.");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];
        s = temp;
    }

    static void Main()
    {
        // Construct delegates.
        StrMod strOp;
        StrMod replaceSp = ReplaceSpaces;
        StrMod removeSp = RemoveSpaces;
        StrMod reverseStr = Reverse;
        string str = "This is a test";

        // Set up multicast.
        strOp = replaceSp;
        strOp += reverseStr;

        // Call multicast.
        strOp(ref str);
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        // Remove replace and add remove.
        strOp -= replaceSp;
        strOp += removeSp;

        str = "This is a test."; // reset string

        // Call multicast.
        strOp(ref str);
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();
    }
}
*/