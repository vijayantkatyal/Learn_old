/*
using System;

class Building
{
    public int Floors;
    public int Area;
    public int Occupants;

    public Building(int f,int a,int o)
    {
        Floors = f;
        Area = a;
        Occupants = o;
    }

    public int AreaPerPerson()
    {
        return Area / Occupants;
    }

    public int MaxOccupants(int minArea)
    {
        return Area / minArea;
    }
}

class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);

        Console.WriteLine("Maximum occupants for house if each has " +
            300 + " sqaure feet: " +
            house.MaxOccupants(300));

        Console.WriteLine("Maximum occupants for office if each has " +
            300 + " sqaure feet: " +
            office.MaxOccupants(300));

    }
}
*/