/*
using System;
using System.Linq;

class Item
{
    public string Name { get; set; }
    public int ItemNumber { get; set; }

    public Item(string n,int num)
    {
        Name = n;
        ItemNumber = num;
    }
}

class InStockStatus
{
    public int ItemNumber { get; set; }
    public bool InStock { get; set; }

    public InStockStatus(int n,bool b)
    {
        ItemNumber = n;
        InStock = b;
    }
}

class Temp
{
    public string Name { get; set; }
    public bool InStock { get; set; }

    public Temp(string n,bool b)
    {
        Name = n;
        InStock = b;
    }
}

class JoinDemo
{
    static void Main()
    {
        Item[] items ={
                         new Item("Pliers",1424),
                         new Item("Hammer",7892),
                         new Item("Wrench",8534),
                         new Item("Saw",6411)
                     };

        InStockStatus[] statuslist ={
                                       new InStockStatus(1424,true),
                                       new InStockStatus(7892,false),
                                       new InStockStatus(8534,true),
                                       new InStockStatus(6411,true)
                                   };

        var inStockList = from item in items
                          join entry in statuslist
                          on item.ItemNumber equals entry.ItemNumber
                          select new { Name = item.Name, InStock = entry.InStock };

        Console.WriteLine("Item\tAvailable\n");

        foreach (var t in inStockList)
            Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
    }
}
*/