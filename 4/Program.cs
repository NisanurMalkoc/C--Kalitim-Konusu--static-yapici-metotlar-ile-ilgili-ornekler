using System;

class Base
{
    static Base()
    {
        Console.WriteLine("Base sınıfının statik yapıcı metodu");
    }

    public Base()
    {
        Console.WriteLine("Base sınıfının statik olmayan yapıcı metodu");
    }
}

class Derived1 : Base
{
    static Derived1()
    {
        Console.WriteLine("Derived1 sınıfının statik yapıcı metodu");
    }

    public Derived1()
    {
        Console.WriteLine("Derived1 sınıfının statik olmayan yapıcı metodu");
    }
}

class Derived2 : Base
{
    static Derived2()
    {
        Console.WriteLine("Derived2 sınıfının statik yapıcı metodu");
    }

    public Derived2()
    {
        Console.WriteLine("Derived2 sınıfının statik olmayan yapıcı metodu");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Derived1 nesnesi oluşturuluyor:");
        Derived1 d1 = new Derived1();

        Console.WriteLine("\nDerived2 nesnesi oluşturuluyor:");
        Derived2 d2 = new Derived2();

        Console.WriteLine("\nTekrar Derived1 nesnesi oluşturuluyor:");
        Derived1 d3 = new Derived1();
    }
}
