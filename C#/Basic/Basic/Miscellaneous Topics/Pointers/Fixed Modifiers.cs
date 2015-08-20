/*
using System;

class Test
{
    public int num;
    
    public Test(int i) 
    { 
        num = i; 
    }
}

class FixedDemo
{
    // Mark Main as unsafe.
    unsafe static void Main()
    {
        Test o = new Test(19);

        fixed (int* p = &o.num) // use fixed to put address of o.num into p
        {
            Console.WriteLine("Intial value of o.num is " + *p);

            *p = 10; // assign 10 to o.num via p

            Console.WriteLine("New value of o.num is " + *p);
        }
    }
}
*/