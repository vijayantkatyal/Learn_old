/*
// Public Vs. Private Access.

using System;

class MyClass
{
    private int alpha;
    int beta;
    public int gamma;

    public void SetAlpha(int a)
    {
        alpha = a;
    }

    public int GetAlpha()
    {
        return alpha;
    }

    public void SetBeta(int a)
    {
        beta = a;
    }

    public int GetBeta()
    {
        return beta;
    }

}

class AccessDemo
{
    static void Main()
    {
        MyClass ob = new MyClass();

        // Access to alpha and beta is allowed only through methods.

        ob.SetAlpha(-99);
        ob.SetBeta(19);

        Console.WriteLine("ob.alpha is " + ob.GetAlpha());
        Console.WriteLine("ob.beta is " + ob.GetBeta());

        // You cannot access alpha or beta like this.
        // ob.alpha = 10; // Alpha is private.
        // ob.beta = 9;   // beta is private.

        ob.gamma = 29; // gamma is public.
        Console.WriteLine("ob.gamma is " + ob.gamma);
    }
}
*/