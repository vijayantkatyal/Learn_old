/*
using System;

struct Book
{
    public string Author;
    public string Title;
    public int Copyright;

    public Book (string a,string t,int c)
    {
        Author = a;
        Title = t;
        Copyright = c;
    }
}

class StructDemo
{
    static void Main()
    {
        Book book1 = new Book("Herb Schildt", "C# 4.0: The Complete Reference", 2010); // explicit constructor.

        Book book2 = new Book(); // Default Constructor
        Book book3; // no constructor.

        Console.WriteLine(book1.Title + " by " + book1.Author + " , (c) " + book1.Copyright);
        Console.WriteLine();

        if (book2.Title == null)
            Console.WriteLine("book2.Title is null");

        // Now, Give Book2 some info.

        book2.Title = "Brave New World";
        book2.Author = "ALdous Huxley";
        book2.Copyright = 1932;
        Console.WriteLine("book2 now contains: ");
        Console.WriteLine(book2.Title + " by " + book2.Author + ", (c) " + book2.Copyright);

        Console.WriteLine();

        book3.Title = "Red Storm Rising";
        Console.WriteLine(book3.Title);

    }
}
*/