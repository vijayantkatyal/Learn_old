/*
using System;
using System.Linq;

class IntoDemo
{
    static void Main()
    {
        string[] websites ={"hsNameA.com","hsNameB.net","hsNameC.net",
                          "hsNameD.com","hsNameE.org","hsNameF.org",
                          "hsNameG.tv","hsNameH.net","hsNameI.tv"};

        var webAddrs = from addr in websites
                       where addr.LastIndexOf('.') != -1
                       group addr by addr.Substring(addr.LastIndexOf('.'))
                           into ws
                           where ws.Count() > 2
                           select ws;

        Console.WriteLine("Top-Level domains with more than 2 members.\n");

        foreach (var sites in webAddrs)
        {
            Console.WriteLine("Contents of " + sites.Key + " domain:");

            foreach (var site in sites)
            {
                Console.WriteLine(" " + site);
            }
            Console.WriteLine();
        }
    }
}
*/