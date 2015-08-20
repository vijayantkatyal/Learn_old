/*
// Redirect Console.Out

using System;
using System.IO;

class Redirect
{
    static void Main()
    {
        StreamWriter log_out = null;

        try
        {
            log_out = new StreamWriter("logfile.txt");

            // Redirect standard out to logfile.txt.
            Console.SetOut(log_out);

            Console.WriteLine("This is start of log file.");

            for (int i = 0; i < 10; i++) Console.WriteLine(i);

            Console.WriteLine("this is end of log file.");
        }

        catch (IOException exc)
        {
            Console.WriteLine("I/O Error\n" + exc.Message);
        }
        finally
        {
            if (log_out != null) log_out.Close();
        }
    }
}
*/