/*
using System;
using System.Globalization;

class charDemo
{
    static void Main()
    {
        string str = "This is a test. $23";
        int i;

        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");

            if (char.IsDigit(str[i]))
                Console.Write(" digit");
            if (char.IsLetter(str[i]))
                Console.Write(" letter");
            if (char.IsLower(str[i]))
                Console.Write(" lowercase");
            if (char.IsUpper(str[i]))
                Console.Write(" uppercase");
            if (char.IsSymbol(str[i]))
                Console.Write(" symbol");
            if (char.IsWhiteSpace(str[i]))
                Console.Write(" seperator");
            if (char.IsPunctuation(str[i]))
                Console.Write(" punctuation");
            Console.WriteLine();
        
        }

        Console.WriteLine("Original: " + str);

        // convert to uppercase.
        string newstr = "";
        for (i = 0; i < str.Length; i++)
        {
            newstr += char.ToUpper(str[i], CultureInfo.CurrentCulture);
        }
        
        Console.WriteLine("Uppercase: " + newstr);
        
    }
}
*/