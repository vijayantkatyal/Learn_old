/*
// Display the digits of an integer using words.

using System;

class ConvertDigitsToWords
{
    static void Main()
    {
        int num;
        int nextdigit;
        int numdigits;
        int[] n = new int[20];

        string[] digits = { "zero", "one", "two", "three", 
                              "four", "five", "six", "seven", 
                              "eight", "nine" };
        num = 1908;

        Console.WriteLine("Number: " + num);

        Console.Write("Number in Words: ");

        nextdigit = 0;
        numdigits = 0;

        // Get Individual digits and store in n.
        // These digits are stored in reverse order.

        do
        {
            nextdigit = num % 10;
            n[numdigits] = nextdigit;
            numdigits++;
            num = num / 10;
        } while (num > 0);
        numdigits--;

        // Display the words.
        for (; numdigits >= 0; numdigits--)
            Console.Write(digits[n[numdigits]] + " ");

        Console.WriteLine();
    }
}
*/