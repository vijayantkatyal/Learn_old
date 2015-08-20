/*
using System;

struct MyStruct
{

}

class MyClass
{

}

class Test<T> where T:struct
{
    T obj;

    public Test(T x)
    {
        obj = x;
    }
}

class ValueConstraintDemo
{
    static void Main()
    {
        Test<MyStruct> x = new Test<MyStruct>(new MyStruct());

        Test<int> y = new Test<int>(10);

        // Test<MyClass> z = new Test<MyClass>(new MyClass()); // illegal.
    }
}
*/