/*
using System;

class A
{
    public void Hello()
    {
        Console.WriteLine("Hello");
    }
}

// Class B inherits A.
class B:A
{

}

class C
{

}

// Because of the base class constraint, all type arguments passed to
// Test must have A as a Base Class.

class Test<T> where T:A
{
    T obj;

    public Test(T o)
    {
        obj = o;
    }

    public void SayHello()
    {
        // ok to call Hello() because it's declared by the base class A.
        obj.Hello();
    }
}

class BaseClassConstraintDemo
{
    static void Main()
    {
        A a = new A();
        B b = new B();
        C c = new C();

        //  the following is valid because A is the specified base class.
        Test<A> t1 = new Test<A>(a);
        t1.SayHello();

        // The following is valid because B inherits A.
        Test<B> t2 = new Test<B>(b);
        t2.SayHello();

        // The following is invalid because C doesnot inherit A.
        //Test<C> t3 = new Test<C>(c);
        //t3.SayHello();
    }
}
*/