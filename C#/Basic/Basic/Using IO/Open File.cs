/*
// Display a text file.

using System;
using System.IO;

class ShowFile
{
    static void Main(string[] args)
    {
        int i;
        FileStream fin;

        if (args.Length != 1)
        {
            Console.WriteLine("Usage: ShowFile File");
            return;
        }

        try
        {
            fin = new FileStream(args[0], FileMode.Open);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Canoot Open File");
            Console.WriteLine(exc.Message);
            return; // end program
        }

        try
        {
            do
            {
                i = fin.ReadByte();
                if (i != -1) Console.Write((char)i);
            }
            while (i != -1);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error Reading File");
            Console.WriteLine(exc.Message);
        }
        finally
        {
            fin.Close();
        }
    }
}
*/