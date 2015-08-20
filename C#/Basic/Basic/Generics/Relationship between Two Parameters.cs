/*
using System;

class A
{

}

class B:A
{

}

// here , V must be or inherit from T.
class Gen<T,V> where V:T
{

}

class NakedConstraintDemo
{
    static void Main()
    {
        // ok, cuz B inherits from A.
        Gen<A, B> x = new Gen<A, B>();

        // error.
        // Gen<B, A> y = new Gen<B, A>();
    }
}
*/