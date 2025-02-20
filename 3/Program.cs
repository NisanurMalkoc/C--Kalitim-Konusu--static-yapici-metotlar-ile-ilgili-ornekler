using System;

class Base
{
    static Base()
    {
        Console.WriteLine("Base static constructor");
    }

    public Base()
    {
        Console.WriteLine("Base instance constructor");
    }
}

class Derived : Base
{
    static Derived()
    {
        Console.WriteLine("Derived static constructor");
    }

    public Derived()
    {
        Console.WriteLine("Derived instance constructor");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("İlk Derived nesnesi:");
        Derived d1 = new Derived();

        Console.WriteLine("\nİkinci Derived nesnesi:");
        Derived d2 = new Derived();

        Console.WriteLine("\nBase sınıfı için nesne oluşturma:");
        Base b1 = new Base();
    }
}