/*
// Value Types are Passed by Values.

using System;

class Test
{
    public void NoChange(int i,int j)
    {
        i = i + j;
        j = -j;
    }
}

class TestDemo
{
    static void Main()
    {
        
        int a = 15, b = 20;

        Console.WriteLine("a and b before call: " + a + " " + b);

        Test t1 = new Test();
        t1.NoChange(a, b);

        Console.WriteLine("a and b after call: " + a + " " + b);
        
    }
}
*/