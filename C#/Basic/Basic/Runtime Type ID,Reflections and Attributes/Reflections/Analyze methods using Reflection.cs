﻿/*
using System;
using System.Reflection;

class MyClass
{
    int x;
    int y;

    public MyClass(int i,int j)
    {
        x = i;
        y = j;
    }

    public int Sum()
    {
        return x + y;
    }

    public bool IsBetween(int i)
    {
        if (x < i && i < y) return true;
        else return false;
    }

    public void Set(int a,int b)
    {
        x = a;
        y = b;
    }

    public void Set(double a,double b)
    {
        x = (int) a;
        y = (int) b;
    }

    public void Show()
    {
        Console.WriteLine("x: {0},y: {1}", x, y);
    }
}

class ReflectDemo
{
    static void Main()
    {
        Type t = typeof(MyClass); // get a Type object representing MyClass

        Console.WriteLine("Analyzing methods in " + t.Name);
        Console.WriteLine();

        Console.WriteLine("Methods Supported: ");

        MethodInfo[] mi = t.GetMethods();

        // display methos supported by MyClass.
        foreach (MethodInfo m in mi)
        {
            // Display return type and name.
            Console.Write(" " + m.ReturnType.Name + " " + m.Name + "(");

            // Display parameters.
            ParameterInfo[] pi = m.GetParameters();

            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length)
                    Console.Write(", ");
            }

            Console.WriteLine(")");
            Console.WriteLine();
        }
    }
}
*/