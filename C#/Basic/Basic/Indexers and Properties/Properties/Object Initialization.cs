/*
// Use object intializers with properties.

using System;

class MyClass
{
    // These are now properties
    public int Count { get; set; }
    public String Str { get; set; }
}

class ObjInitdemo
{
    static void Main()
    {
        // Construct a MyClass object by using object initialzers.
        MyClass obj = new MyClass { Count = 100, Str = "Testing" };

        Console.WriteLine(obj.Count + " " + obj.Str);
    }
}
*/