/*
// Copy a file usng File.Copy()
// baisc 1.txt 2.txt

using System;
using System.IO;

class CopyFile
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: CopyFile From To");
            return;
        }

        // Copy the files
        try
        {
            File.Copy(args[0], args[1]);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error Copying File\n" + exc.Message);
        }
    }
}
*/