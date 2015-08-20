/*
using System;
using System.Linq;

class Account
{
    public string FirstNAme { get; private set; }
    public string LastName { get; private set; }
    public double Balance { get; private set; }
    public string AccountNumber { get; private set; }

    public Account(string fn,string ln,string accnum,double b)
    {
        FirstNAme = fn;
        LastName = ln;
        AccountNumber = accnum;
        Balance = b;
    }
}

class OrderByDemo
{
    static void Main()
    {
        Account[] accounts ={new Account("Tom","Smith","132CK",100.23),
                           new Account("Tom","Smith","132CD",1000.00),
                           new Account("Ralph","Jones","436CD",1923.85)};

        var accinfo = from acc in accounts
                      orderby acc.LastName, acc.FirstNAme, acc.Balance
                      select acc;

        Console.WriteLine("Accounts in Sorted Order: ");
        string str = "";

        foreach (Account acc in accinfo)
        {
            if (str != acc.FirstNAme)
            {
                str = acc.FirstNAme;
            }
            Console.WriteLine("{0}, {1}\tAcc#: {2},{3,10:C}", acc.LastName, acc.FirstNAme, acc.AccountNumber, acc.Balance);
        }
        Console.WriteLine();
    }
}
*/