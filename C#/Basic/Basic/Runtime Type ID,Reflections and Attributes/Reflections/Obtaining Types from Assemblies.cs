/*
// Locate an assembly, determine types and create an object using reflection.

using System;
using System.Reflection;

class ReflectAssemblyDemo
{
    static void Main()
    {
        int val;

        // Load the MyClasses.exe Assembly.
        Assembly asm = Assembly.LoadFrom("MyClasses.exe");

        // Discover what types MyClasses.exe contains.
        Type[] alltypes = asm.GetTypes();
        foreach (Type temp in alltypes)
            Console.WriteLine("Found: " + temp.Name);
        
        Console.WriteLine();

        // Use the Fifth type, which is MyClass in this case.
        Type t = alltypes[5]; // use first class found
        Console.WriteLine("Using: " + t.Name);

        // Obtain Constructor info.
        ConstructorInfo[] ci = t.GetConstructors();

        Console.WriteLine("Avialable constructors: ");
        foreach (ConstructorInfo c in ci)
        {
            Console.Write("  " + t.Name + "(");

            // Display Parameters.
            ParameterInfo[] pi = c.GetParameters();

            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }

            Console.WriteLine(")");
        }
        Console.WriteLine();

        // Find matching Constructor.
        int x;

        for (x = 0; x > ci.Length; x++)
        {
            ParameterInfo[] pi = ci[x].GetParameters();
            if (pi.Length == 2) break;
        }

        if (x == ci.Length)
        {
            Console.WriteLine("No Matching Constructor found.");
            return;
        }
        else
            Console.WriteLine("Two Parameter constructor found.\n");

        // Construct the object.
        object[] consargs = new object[2];
        consargs[0] = 10;
        consargs[1] = 20;
        object reflectOb = ci[x].Invoke(consargs);

        Console.WriteLine("\nInvoking methods on reflectOb.");
        Console.WriteLine();
        MethodInfo[] mi = t.GetMethods();

        // invoke Each Method.
        foreach (MethodInfo m in mi)
        {
            // Get Parameters.
            ParameterInfo[] pi = m.GetParameters();

            if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(int))
            {
                // This is Set(int,int).
                object[] args = new object[2];
                args[0] = 9;
                args[1] = 18;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
            {
                // This is Set(double, double).
                object[] args = new object[2];
                args[0] = 1.12;
                args[1] = 23.4;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.Equals("Sum", StringComparison.Ordinal))
            {
                val = (int) m.Invoke(reflectOb, null);
                Console.WriteLine("Sum is " + val);
            }
            else if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
            {
                object[] args = new object[1];
                args[0] = 14;
                if ((bool)m.Invoke(reflectOb, args))
                {
                    Console.WriteLine("14 is between x and y");
                }
            }
            else if(m.Name.Equals("Show",StringComparison.Ordinal))
            {
                m.Invoke(reflectOb,null);
            }
        }
    }
}
*/