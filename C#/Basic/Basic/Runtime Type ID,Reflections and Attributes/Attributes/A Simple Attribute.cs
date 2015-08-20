﻿/*
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]

public class RemarkAttribute:Attribute
{
    string pri_remark; // Underlies Remark property

    public RemarkAttribute(string comment)
    {
        pri_remark=comment;
    }

    public string Remark
    {
        get
        {
            return pri_remark;
        }
    }
}

[RemarkAttribute("This class uses an attribute.")]
class UseAttrib
{
    // ...
}

class AttribDemo
{
    static void Main()
    {
        Type t=typeof(UseAttrib);

        Console.Write("Attributes in "+t.Name+": ");

        object[] attribs=t.GetCustomAttributes(false);

        foreach(object o in attribs)
        {
            Console.WriteLine(o);
        }

        Console.Write("Remark: ");

        // Retrieve the RemarkAttribute.
        Type tRemArt=typeof(RemarkAttribute);
        RemarkAttribute ra=(RemarkAttribute) Attribute.GetCustomAttribute(t,tRemArt);

        Console.WriteLine(ra.Remark);
    }
}
*/