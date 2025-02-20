// See httpusing System;

class X
{
    static X()
    {
        Console.WriteLine("X'in statik yapıcı metodu çalıştı.");
    }
    public X()
    {
        Console.WriteLine("X'in instance yapıcı metodu çalıştı.");
    }
}

class Y : X
{
    static Y()
    {
        Console.WriteLine("Y'in statik yapıcı metodu çalıştı.");
    }
    public Y()
    {
        Console.WriteLine("Y'in instance yapıcı metodu çalıştı.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Birinci nesne oluşturuluyor:");
        Y y1 = new Y();

        Console.WriteLine("\nİkinci nesne oluşturuluyor:");
        X x1 = new X();

        Console.WriteLine("\nÜçüncü nesne oluşturuluyor:");
        Y y2 = new Y();
    }
}
