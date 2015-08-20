/*
using System;

class MyClass
{
    public int i;

    public MyClass(int x)
    {
        i = x;
    }
}

class ActionDemo
{
    // An Action Method.
    // It Displays the value it is passed.
    
    static void Show(MyClass o)
    {
        Console.Write(o.i + " ");
    }

    // Another Action Method.
    // It negates the value it is passed.
    static void Neg(MyClass o)
    {
        o.i = -o.i;
    }

    static void Main()
    {
        MyClass[] nums = new MyClass[5];

        nums[0] = new MyClass(5);
        nums[1] = new MyClass(2);
        nums[2] = new MyClass(3);
        nums[3] = new MyClass(4);
        nums[4] = new MyClass(1);

        Console.Write("Contents of nums: ");

        // Use Action to Show the Values.
        Array.ForEach(nums, ActionDemo.Show);

        Console.WriteLine();

        // Use Action to negate the values.
        Array.ForEach(nums, ActionDemo.Neg);

        Console.Write("Contents of nums negated: ");

        Array.ForEach(nums, ActionDemo.Show);

        Console.WriteLine();
    }
}
*/