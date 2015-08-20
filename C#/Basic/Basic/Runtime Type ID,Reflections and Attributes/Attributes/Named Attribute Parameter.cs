﻿/*
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute:Attribute
{
    string pri_remark;

    public string Supplement;

    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
        Supplement = "None";
    }

    public string Remark
    {
        get
        {
            return pri_remark;
        }
    }
}

[RemarkAttribute("This class uses an attribute.",Supplement="This is additional info.")]
class UseAttrib
{
    // ...
}

class NamedParamDemo
{
    static void Main()
    {
        Type t = typeof(UseAttrib);

        Console.Write("attributes in " + t.Name + ": ");

        object[] attribs = t.GetCustomAttributes(false);
        foreach (object o in attribs)
        {
            Console.WriteLine(o);
        }

        // Retrieve the RemarkAttribute.
        Type tRemAtt = typeof(RemarkAttribute);
        RemarkAttribute ra = (RemarkAttribute) Attribute.GetCustomAttribute(t, tRemAtt);

        Console.Write("Remark: ");
        Console.WriteLine(ra.Remark);

        Console.Write("Supplement: ");
        Console.WriteLine(ra.Supplement);
    }
}
*/