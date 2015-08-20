/*
using System;

class Encode
{
    static void Main()
    {
        char ch1 = 'H';
        char ch2 = 'i';
        char ch3 = '!';
        int key = 88;

        Console.WriteLine("Original Message: " + ch1 + ch2 + ch3);

        // Encode the Message.

        ch1 = (char)(ch1 ^ key);
        ch2 = (char)(ch2 ^ key);
        ch3 = (char)(ch3 ^ key);

        Console.WriteLine("Encoded Message: " + ch1 + ch2 + ch3);

        // Decode the Message.

        ch1 = (char)(ch1 ^ key);
        ch2 = (char)(ch2 ^ key);
        ch3 = (char)(ch3 ^ key);

        Console.WriteLine("Decoded Message: " + ch1 + ch2 + ch3);
    }
}
*/