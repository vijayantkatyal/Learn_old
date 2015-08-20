/*
using System;
using System.IO;

class UsingDemo
{
    static void Main()
    {
        try
        {
            StreamReader sr = new StreamReader("text.txt");

            using (sr)
            {

            }
        }
        catch (IOException exc)
        {

        }

        try
        {
            using (StreamReader sr2 = new StreamReader("test.txt"))
            {

            }
        }
        catch (IOException exc)
        {

        }
    }
}
*/