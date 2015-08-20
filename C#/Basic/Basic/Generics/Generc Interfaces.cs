/*
using System;

public interface ISeries<T>
{
    T GetNext();
    void Reset();
    void SetStart(T v);
}

class ByTwos<T>:ISeries<T>
{
    T start;
    T val;

    public delegate T IncByTwo(T v);

    IncByTwo incr;

    public ByTwos(IncByTwo incrMeth)
    {
        start = default(T);
        val= default(T);
        incr = incrMeth;
    }

    public T GetNext()
    {
        val=incr(val);
        return val;
    }

    public void Reset()
    {
        val=start;
    }

    public void SetStart(T v)
    {
        start=v;
        val=start;
    }
}

class ThreeD
{
    public int x,y,z;

    public ThreeD(int a,int b,int c)
    {
        x=a;
        y=b;
        z=c;
    }
}

class GetIntfDemo
{
    static int IntPlusTwo(int v)
    {
        return v + 2;
    }

    static double DoublePlusTwo(double v)
    {
        return v + 2.0;
    }

    static ThreeD ThreeDPlusTwo(ThreeD v)
    {
        if(v==null) return new ThreeD(0,0,0);
        else return new ThreeD(v.x+2,v.y+2,v.z+2);
    }

    static void Main()
    {
        ByTwos<int> intBT=new ByTwos<int>(IntPlusTwo);

        for(int i=0;i<5;i++)
            Console.Write(intBT.GetNext()+" ");

        Console.WriteLine();

        ByTwos<double> dblBT=new ByTwos<double>(DoublePlusTwo);
        dblBT.SetStart(11.4);

        for(int i=0;i<5;i++)
        {
            Console.Write(dblBT.GetNext()+" ");
        }
        Console.WriteLine();

        ByTwos<ThreeD> ThrDBT=new ByTwos<ThreeD>(ThreeDPlusTwo);

        ThreeD coord;
        for(int i=0;i<5;i++)
        {
            coord=ThrDBT.GetNext();
            Console.WriteLine(coord.x + "," + coord.y + "," + coord.y + " ");
        }

        Console.WriteLine();
    }
}
*/