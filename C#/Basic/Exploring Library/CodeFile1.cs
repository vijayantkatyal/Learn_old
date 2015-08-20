/*
using System;
using System.Threading.Tasks;

class Demo
{
    static async void GreetUserAsync(string name)
    {
        await TaskEx.Run(() => Console.WriteLine("Hello,{0}", name));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Async CTP Simple Console App");
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Calling asynch method...");
        GreetUserAsync(name);
        Console.ReadLine();
    }
}
*/