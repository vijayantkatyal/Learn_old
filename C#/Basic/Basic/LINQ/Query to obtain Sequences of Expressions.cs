﻿/*
using System;
using System.Linq;

class ContactInfo
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public ContactInfo(string n,string a,string p)
    {
        Name = n;
        Email = a;
        Phone = p;
    }
}

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

class SelectDemo3
{
    static void Main()
    {
        ContactInfo[] contacts ={
                                   new ContactInfo("Herb","Herb@HerbSchildt.com","555-1010"),
                                   new ContactInfo("Tom","Tom@HerbSchildt.com","555-1101"),
                                   new ContactInfo("Sara","Sara@HerbSchildt.com","555-0110")
                               };

        var emailList = from entry in contacts
                        select new EmailAddress(entry.Name, entry.Email);

        Console.WriteLine("The Email list is");

        foreach (EmailAddress e in emailList)
            Console.WriteLine(" {0}: {1}", e.Name, e.Address);
    }
}
*/