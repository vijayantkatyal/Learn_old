/*
using System;
using System.Linq;

class GroupDemo
{
    static void Main()
    {
        string[] websites ={"hsNameA.com","hsNameB.net","hsNameC.net",
                          "hsNameD.com","hsNameE.org","hsNameF.org",
                          "hsNameG.tv","hsNameH.net","hsNameI.tv"};

        var webAddrs = websites.Where(w => w.LastIndexOf('.') != -1).GroupBy(x => x.Substring(x.LastIndexOf(".")));

        foreach (var sites in webAddrs)
        {
            Console.WriteLine("Web Sites grouped by " + sites.Key);

            foreach (var site in sites)
            {
                Console.WriteLine(" " + site);
            }
            Console.WriteLine();
        }
    }
}
*/