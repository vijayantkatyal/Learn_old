/*
using System;
using System.Linq;

class Transport
{
    public string Name { get; set; }
    public string How { get; set; }

    public Transport(string n,string h)
    {
        Name = n;
        How = h;
    }
}

class GroupJoinDemo
{
    static void Main()
    {
        string[] travelTypes ={
                                 "Air",
                                 "Sea",
                                 "Land"
                             };

        Transport[] transports ={
                                   new Transport("Bicycle","Land"),
                                   new Transport("Balloon","Air"),
                                   new Transport("Boat","Sea"),
                                   new Transport("Jet","Air"),
                                   new Transport("Canoe","Sea"),
                                   new Transport("Biplane","Air"),
                                   new Transport("Car","Land"),
                                   new Transport("Cargo Ship","Sea"),
                                   new Transport("Train","Land")
                               };

        var byHow = from how in travelTypes
                    join trans in transports
                    on how equals trans.How
                    into lst
                    select new { How = how, Tlist = lst };

        foreach (var t in byHow)
        {
            Console.WriteLine("{0} transportation includes:", t.How);

            foreach (var m in t.Tlist)
                Console.WriteLine(" " + m.Name);

            Console.WriteLine();
        }
    }
}
*/