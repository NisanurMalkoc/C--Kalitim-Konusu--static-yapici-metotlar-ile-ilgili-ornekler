using System;

class Parent
{
    static Parent()
    {
        Console.WriteLine("Parent static constructor çalıştı.");
    }

    public Parent()
    {
        Console.WriteLine("Parent instance constructor çalıştı.");
    }
}

class Child : Parent
{
    static Child()
    {
        Console.WriteLine("Child static constructor çalıştı.");
    }

    public Child()
    {
        Console.WriteLine("Child instance constructor çalıştı.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("İlk Child nesnesi:");
        Child c1 = new Child();

        Console.WriteLine("\nİkinci Child nesnesi:");
        Child c2 = new Child();
    }
}
