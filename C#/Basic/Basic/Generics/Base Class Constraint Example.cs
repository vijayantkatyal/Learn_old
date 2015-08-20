﻿/*
using System;

class NotFoundException:Exception
{
    public NotFoundException():base() {}
    public NotFoundException(string message):base(message) {}
    public NotFoundException(string message,Exception innerException):base(message,innerException) {}
    protected NotFoundException(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context):base(info,context) { }
}

class PhoneNumber
{
    public string Number {get;set;}
    public string Name {get;set;}
    public PhoneNumber(string n,string num)
    {
        Name=n;
        Number=num;
    }
}

class Friend:PhoneNumber
{
    public bool IsWorkNumber {get; private set;}

    public Friend(string n,string num,bool wk):base(n,num)
    {
        IsWorkNumber=wk;
    }
}

class Supplier:PhoneNumber
{
    public Supplier(string n,string num):base(n,num)
    {
      
    }
}

class EmailFriend {}

class PhoneList<T> where T:PhoneNumber
{
    T[] phList;
    int end;

    public PhoneList()
    {
        phList=new T[10];
        end=0;
    }

    public bool Add(T newEntry)
    {
        if(end==10) return false;

        phList[end]=newEntry;
        end++;

        return true;
    }

    public T FindByName(string name)
    {
        for(int i=0;i<end;i++)
        {
            if(phList[i].Name==name)
                return phList[i];
        }

        throw new NotFoundException();
    }

    public T FindByNumber(string number)
    {
        for (int i = 0; i < end; i++)
        {
            if (phList[i].Number == number)
                return phList[i];
        }

        throw new NotFoundException();
    }
}

class UseBaseClassConstraint
{
    static void Main()
    {
        PhoneList<Friend> plist=new PhoneList<Friend>();
        plist.Add(new Friend("Tom","555-1234",true));
        plist.Add(new Friend("Gary","555-6756",true));
        plist.Add(new Friend("Matt","555-9254",false));

        try
        {
            Friend frnd=plist.FindByName("Gary");

            Console.WriteLine(frnd.Name+" : "+frnd.Number);

            if(frnd.IsWorkNumber)
            {
                Console.WriteLine(" (work) ");
            }
            else
                Console.WriteLine();
        }
        
        catch(NotFoundException)
        {
            Console.WriteLine("Not Found");
        }
        
        Console.WriteLine();

        PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
        plist2.Add(new Supplier("Global Hardware", "555-8834"));
        plist2.Add(new Supplier("Computer Warehouse", "555-9256"));
        plist2.Add(new Supplier("NetworkCity", "555-2564"));

        try
        {
            Supplier sp = plist2.FindByNumber("555-2564");
            Console.WriteLine(sp.Name + " : " + sp.Number);
        }
        catch
        {
            Console.WriteLine("Not Found");
        }

        // Error doesn't inherit PHoneNumber.
        //PhoneList<EmailFriend> plist3 = new PhoneList<EmailFriend>(); // Error
    }
}
*/