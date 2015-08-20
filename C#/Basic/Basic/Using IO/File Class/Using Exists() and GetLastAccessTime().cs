/*
// Use Exists() and GetLastAccessTime().

using System;
using System.IO;

class ExistsDemo
{
    static void Main()
    {
        if (File.Exists("test.txt"))
            Console.WriteLine("File Exists. It was last accessed at " + File.GetLastAccessTime("text.txt"));
        else
            Console.WriteLine("Does not Exist");
    }
}
*/