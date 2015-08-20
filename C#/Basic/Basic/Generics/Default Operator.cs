/*
using System;

class MyClass
{

}

class Test<T>
{
    public T obj;

    public Test()
    {
        // obj = null; // can't use. only for reference type.

        // obj = 0; // can't use. only for numeric value type.

        obj = default(T); // for both numeric and reference type.
    }
}

class DefaultDemo
{
    static void Main()
    {
        Test<MyClass> x = new Test<MyClass>();

        if (x.obj == null)
            Console.WriteLine("x.obj is null");

        Test<int> y = new Test<int>();

        if (y.obj == 0)
            Console.WriteLine("y.obj is 0");
    }
}
*/