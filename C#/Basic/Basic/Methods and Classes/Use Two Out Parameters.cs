/*
// Use Two Out Paramters.

using System;

class Num
{
    public bool HasComFactor(int x,int y,out int least,out int greatest)
    {
        int i;
        int max = x < y ? x : y;
        bool first = true;

        least = 1;
        greatest = 1;

        // Find least and greatest common factors.
        for (i = 2; i <= max / 2 + 1; i++)
        {
            if (((y % i) == 0) & ((x % i) == 0))
            {
                if (first)
                {
                    least = i;
                    first = false;
                }
                greatest = i;
            }
        }

        if (least != 1) return true;
        else return false;

    }
}

class DemoOut
{
    static void Main()
    {
        Num ob = new Num();
        int lcf, gcf;

        if (ob.HasComFactor(231, 105, out lcf, out gcf))
        {
            Console.WriteLine("LCF of 231 and 105 is " + lcf);
            Console.WriteLine("GCF of 231 and 105 is " + gcf);
        }
        else
            Console.WriteLine("No Common factor for 35 and 49.");

        if (ob.HasComFactor(35, 51, out lcf, out gcf))
        {
            Console.WriteLine("LCF of 35 and 51 is " + lcf);
            Console.WriteLine("GCF of 35 and 51 is " + gcf);
        }
        else
            Console.WriteLine("No Common factor for 35 and 51.");
    }
}
*/