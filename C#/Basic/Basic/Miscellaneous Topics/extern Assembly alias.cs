/*
// extern alias statements must be at the top of the file.
extern alias Asm1;
extern alias Asm2;
using System;
class Demo
{
    static void Main()
    {
        Asm1::MyNS.MyClass t = new Asm1::MyNS.MyClass();
        Asm2::MyNS.MyClass t2 = new Asm2::MyNS.MyClass();
    }
}
*/