/*
// use an indexer to create a fail-soft array.

using System;

class FailSoftArray
{
    int[] a; // reference to underlying array.

    public int length; // length is public.

    public bool ErrFlag;

    // COnstruct array given its size.
    public FailSoftArray(int size)
    {
        a = new int[size];
        length = size;
    }

    private bool ok(int index)
    {
        if (index >= 0 & index < length) return true;
        return false;
    }

    // this is indexer for FailSoftArray.
    public int this[int index]
    {
        // this is get accessor.
        get
        {
            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
            
        }

        // this is set accessor.
        set
        {
            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else
            {
                ErrFlag = true;
            }
        }
    }
}

class FSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        int x;

        Console.WriteLine("Fail Quietly");
        for (int i = 0; i < (fs.length * 2); i++)
        {
            fs[i] = i * 10;
        }

        for (int i = 0; i < (fs.length * 2); i++)
        {
            x = fs[i];
            if (x != -1) Console.Write(x + " ");
        }

        Console.WriteLine();

        Console.WriteLine("\nFail with error reports.");
        for (int i = 0; i < (fs.length * 2); i++)
        {
            fs[i] = i * 10;
            if (fs.ErrFlag)
                Console.WriteLine("fs[" + i + "] out-of-bounds");
        }

        for (int i = 0; i < (fs.length * 2); i++)
        {
            x = fs[i];
            if (!fs.ErrFlag) Console.Write(x + " ");
            else
                Console.WriteLine("fs[" + i + "] out-of-bounds");
        }
    }
}
*/