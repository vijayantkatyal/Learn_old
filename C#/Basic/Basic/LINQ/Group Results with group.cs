﻿/*
using System;
using System.Linq;

class GroupDemo
{
    static void Main()
    {
        string[] websites ={"hsNameA.com","hsNameB.net","hsNameC.net",
                          "hsNameD.com","hsNameE.org","hsNameF.org",
                          "hsNameG.tv","hsNameH.net","hsNameI.tv"};

        var webAddrs = from addr in websites
                       where addr.LastIndexOf('.') != -1
                       group addr by addr.Substring(addr.LastIndexOf('.'));

        foreach (var sites in webAddrs)
        {
            Console.WriteLine("Web sites grouping by " + sites.Key);

            foreach (var site in sites)
            {
                Console.WriteLine(" " + site);
            }
        }
        Console.WriteLine();
    }
}
*/