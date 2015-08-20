/*
using System;
using System.Linq;

class EmailAddress
{
    public string Name { get; set; }
    public string Address { get; set; }

    public EmailAddress(string n,string a)
    {
        Name = n;
        Address = a;
    }
}

class SelectDemo2
{
    static void Main()
    {
        EmailAddress[] addrs ={
                                 new EmailAddress("Herb","Herb@HerbSchildt.com"),
                                 new EmailAddress("Tom","Tom@HerbSchildt.com"),
                                 new EmailAddress("Sara","Sara@HerbSchildt.com")
                             };

        var eAddrs = from entry in addrs
                     select entry.Address;
        Console.WriteLine("The Email Addresses are");

        foreach (string s in eAddrs) Console.WriteLine(" " + s);
    }
}
*/