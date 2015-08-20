/*
using System;

class X
{
    public int Val;
}

class Y : X
{

}

delegate X ChangeIt(Y ob);

class CoContraVariance
{
    static X IncrA(X obj)
    {
        X temp = new X();
        temp.Val = obj.Val + 1;
        return temp;
    }

    static Y IncrB(Y obj)
    {
        Y temp = new Y();
        temp.Val = obj.Val + 1;
        return temp;
    }

    static void Main()
    {
        Y Yob = new Y();

        ChangeIt change = IncrA; // contravariance

        X Xob=change(Yob);

        Console.WriteLine("Xob: "+Xob.Val);

        change = IncrB; // covariance

        Yob=(Y) change(Yob);

        Console.WriteLine("Yob: "+Yob.Val);
    }
}
*/