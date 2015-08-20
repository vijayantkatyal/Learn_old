/*
using System;

class CompareDemo
{
    static void Main()
    {
        string str1 = "alpha";
        string str2 = "Alpha";
        string str3 = "Beta";
        string str4 = "alpha";
        string str5 = "alpha,beta";

        int result;

        #region String Comparsion Culture
        
        result = string.Compare(str1, str2, StringComparison.CurrentCulture);
        Console.Write("Using a Culture Sensitive Comparison: ");
        if (result < 0)
            Console.WriteLine(str1 + " is less than " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " is greater than " + str2);
        else
            Console.WriteLine(str1 + " equals " + str2);
        
        #endregion

        #region String Comparison Ordinal
        
        result = string.Compare(str1, str2, StringComparison.Ordinal);
        Console.Write("Using an ordinal comparison: ");
        if (result < 0)
            Console.WriteLine(str1 + " is less than " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " is greater than " + str2);
        else
            Console.WriteLine(str1 + " equals " + str4);

        #endregion

        #region Compare Ordinal
        
        // Use Compare Ordinal Method
        result = string.CompareOrdinal(str1, str2);
        Console.Write("using compareordinal(): ");
        if (result < 0)
            Console.WriteLine(str1 + " is less than " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " is greater than " + str2);
        else
            Console.WriteLine(str1 + " equals " + str4);

        #endregion

        Console.WriteLine();

        if (str1 != str3) Console.WriteLine(str1 + " != " + str3);
        if (str1 != str2) Console.WriteLine(str1 + " != " + str2);

        Console.WriteLine();

        if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("Using Equals() with Ordinal IgnoreCase, " +
                str1 + " equals " + str2);

        Console.WriteLine();

        #region Compare Portion of String

        if (String.Compare(str2, 0, str5, 0, 3, StringComparison.CurrentCulture) > 0)
        {
            Console.WriteLine("Using the Current culture , the first " +
                "3 characters of " + str2 + "\nare greater than first " +
                "3 Characters of " + str5);
        }
        #endregion
    }
}
*/