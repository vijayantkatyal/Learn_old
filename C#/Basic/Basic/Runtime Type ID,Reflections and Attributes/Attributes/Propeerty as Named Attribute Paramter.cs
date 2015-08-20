/*
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute:Attribute
{
    string pri_mark;

    public string Supplement; // named Attribute

    public int Priority { get; set; } // name Attribute

    public RemarkAttribute(string comment)
    {
        pri_mark = comment;
        Supplement = "None";
        Priority = 1;
    }

    public string Remark
    {
        get
        {
            return pri_mark;
        }
    }
}

[RemarkAttribute("This class uses an attribute.",Supplement="This is additional info.",Priority=10)]
class UseAttrib
{
    // ...
}

class namedParamDemo
{
    static void Main()
    {
        Type t = typeof(UseAttrib);

        Console.Write("Attributes in " + t.Name + ": ");

        object[] attribs = t.GetCustomAttributes(false);
        foreach (object o in attribs)
        {
            Console.WriteLine(o);
        }

        // Retrieve the RemarkAttribute.
        Type tRemAtt = typeof(RemarkAttribute);
        RemarkAttribute ra = (RemarkAttribute)Attribute.GetCustomAttribute(t, tRemAtt);

        Console.Write("Remark: ");
        Console.WriteLine(ra.Remark);

        Console.Write("Supplement: ");
        Console.WriteLine(ra.Supplement);

        Console.WriteLine("Priority: " + ra.Priority);
    }
}
*/