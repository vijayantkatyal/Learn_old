/*
using System;

class Building
{
    public int Floors;
    public int Area;
    public int Occupants;

    public int AreaPerPerson()
    {
        return Area / Occupants;
    }

    // Return the maximum number of occupants if each
    // is to have at least the specified minimum area.

    public int MaxOccupant(int minArea)
    {
        return Area / minArea;
    }
}

// Use MaxOccupant().

class BuildingDemo
{
    static void Main()
    {
        Building house = new Building();
        Building office = new Building();

        // Assign values to fields in house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;

        // Assign values to fields in office.
        office.Occupants = 25; 
        office.Area = 4200;
        office.Floors = 3;

        Console.WriteLine("Maximum occupants for house if each has " +
            300 + " square feet: " +
            house.MaxOccupant(300));
        Console.WriteLine("Maximum occupants for office if each has "
            + 300 + " square feet: " + office.MaxOccupant(300));
    }
}
*/